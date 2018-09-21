﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class CameraManager : FrameComponent
{
	protected Dictionary<string, GameCamera> mCameraList;
	protected GameCamera mMainCamera;
	protected GameCamera mUICamera;
	public CameraManager(string name)
		:base(name)
	{
		mCameraList = new Dictionary<string, GameCamera>();
	}
	public override void init()
	{
		findMainCamera();
		GameObject parent = mLayoutManager.getNGUIRoot().mObject;
		mUICamera = getCamera("UICamera", parent);
	}
	public override void destroy()
	{
		base.destroy();
	}
	public override void update(float elapsedTime)
	{
		foreach(var camera in mCameraList)
		{
			camera.Value.update(elapsedTime);
		}
	}
	public override void lateUpdate(float elapsedTime)
	{
		foreach (var camera in mCameraList)
		{
			camera.Value.lateUpdate(elapsedTime);
		}
	}
	// 获得摄像机,名字是场景中摄像机的名字
	public GameCamera getCamera(string name, GameObject parent = null, bool createIfNull = true)
	{
		if(mCameraList.ContainsKey(name))
		{
			return mCameraList[name];
		}
		else if(createIfNull)
		{
			return createCamera(name, parent);
		}
		return null;
	}
	public GameCamera createCamera(string name, GameObject parent = null, bool newCamera = false)
	{
		GameCamera camera = null;
		GameObject obj = getGameObject(parent, name);
		if(obj == null && newCamera)
		{
			obj = UnityUtility.createObject(name, parent);
		}
		if (obj != null)
		{
			camera = new GameCamera(name);
			camera.init();
			camera.setObject(obj);
			mCameraList.Add(camera.getName(), camera);
		}
		return camera;
	}
	public void findMainCamera()
	{
		string name = "MainCamera";
		if(getCamera(name, null, false) != null)
		{
			destroyCamera(name);
		}
		mMainCamera = createCamera(name);
	}
	public GameCamera getMainCamera(){return mMainCamera;}
	public GameCamera getUICamera(){return mUICamera;}
	public void destroyCamera(string name)
	{
		GameCamera camera = getCamera(name);
		if(camera == null)
		{
			return;
		}
		camera.destroy();
		mCameraList.Remove(name);
		if (camera == mMainCamera)
		{
			mMainCamera = null;
		}
		else if(camera == mUICamera)
		{
			mUICamera = null;
		}
	}
}