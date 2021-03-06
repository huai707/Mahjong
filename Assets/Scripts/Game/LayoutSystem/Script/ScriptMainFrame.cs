﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class ScriptMainFrame : LayoutScript
{
	protected txUIObject mBackground;
	protected txUIObject mBottomButtonRoot;
	protected txUIObject mLeftTopButtonRoot;
	protected txNGUISprite mFrameTitle;
	protected txNGUIButton mMailButton;
	protected txNGUIButton mCompetitionButton;
	protected txNGUIButton mShareButton;
	protected txNGUIButton mStandingButton;
	protected txNGUIButton mRuleButton;
	protected txNGUIButton mContactButton;
	protected txNGUIButton mRechargeButton;
	protected txNGUIButton mSettingButton;
	protected txNGUIButton mQuitButton;
	public ScriptMainFrame(string name, GameLayout layout)
		:
		base(name, layout)
	{
		;
	}
	public override void assignWindow()
	{
		newObject(out mBackground, "Background");
		newObject(out mBottomButtonRoot, mBackground, "BottomButtonRoot");
		newObject(out mLeftTopButtonRoot, mBackground, "LeftTopButtonRoot");
		newObject(out mFrameTitle, mBackground, "FrameTitle");
		newObject(out mMailButton, mBottomButtonRoot, "MailButton");
		newObject(out mCompetitionButton, mBottomButtonRoot, "CompetitionButton");
		newObject(out mShareButton, mBottomButtonRoot, "ShareButton");
		newObject(out mStandingButton, mBottomButtonRoot, "StandingButton");
		newObject(out mRuleButton, mBottomButtonRoot, "RuleButton");
		newObject(out mContactButton, mBottomButtonRoot, "ContactButton");
		newObject(out mRechargeButton, mLeftTopButtonRoot, "RechargeButton");
		newObject(out mSettingButton, mLeftTopButtonRoot, "SettingButton");
		newObject(out mQuitButton, mLeftTopButtonRoot, "QuitButton");
	}
	public override void init()
	{
		registeBoxColliderNGUI(mMailButton, onMailButton, onButtonPress);
		registeBoxColliderNGUI(mCompetitionButton, onCompetitionButton, onButtonPress);
		registeBoxColliderNGUI(mShareButton, onShareButton, onButtonPress);
		registeBoxColliderNGUI(mStandingButton, onStandingButton, onButtonPress);
		registeBoxColliderNGUI(mRuleButton, onRuleButton, onButtonPress);
		registeBoxColliderNGUI(mContactButton, onContactButton, onButtonPress);
		registeBoxColliderNGUI(mRechargeButton, onRechargeButton, onButtonPress);
		registeBoxColliderNGUI(mSettingButton, onSettingButton, onButtonPress);
		registeBoxColliderNGUI(mQuitButton, onQuitButton, onButtonPress);
	}
	public override void onReset()
	{
		LT.SCALE_WINDOW(mMailButton);
		LT.SCALE_WINDOW(mCompetitionButton);
		LT.SCALE_WINDOW(mShareButton);
		LT.SCALE_WINDOW(mStandingButton);
		LT.SCALE_WINDOW(mRuleButton);
		LT.SCALE_WINDOW(mContactButton);
		LT.SCALE_WINDOW(mRechargeButton);
		LT.SCALE_WINDOW(mSettingButton);
		LT.SCALE_WINDOW(mQuitButton);
	}
	public override void onShow(bool immediately, string param)
	{
		;
	}
	public override void onHide(bool immediately, string param)
	{
		;
	}
	public override void update(float elapsedTime)
	{
		;
	}
	//-------------------------------------------------------------------------------------------------------------------------
	protected void onMailButton(GameObject obj)
	{
		;
	}
	protected void onCompetitionButton(GameObject obj)
	{
		;
	}
	protected void onShareButton(GameObject obj)
	{
		;
	}
	protected void onStandingButton(GameObject obj)
	{
		;
	}
	protected void onRuleButton(GameObject obj)
	{
		;
	}
	protected void onContactButton(GameObject obj)
	{
		;
	}
	protected void onRechargeButton(GameObject obj)
	{
		;
	}
	protected void onSettingButton(GameObject obj)
	{
		;
	}
	protected void onQuitButton(GameObject obj)
	{
		;
	}
	protected void onButtonPress(GameObject obj, bool press)
	{
		txUIObject window = mLayout.getUIObject(obj);
		LT.SCALE_WINDOW(window, window.getScale(), press ? new Vector2(1.2f, 1.2f) : Vector2.one, 0.2f);
	}
}