﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Fusion.Engine.Input;
using Fusion.Core.Mathematics;

namespace TestGame2 {
	public class UIConfig {
		[ Category("FreeCamera") ]	
		[ Description("Enables direct first person camera control. Warning: Enabling free camera will force hiding, clipping and cenetring of the mouse") ]
		public bool		FreeCamEnabled		{ set; get; }

		[ Description("Camera FOV") ]
		[ Category("FreeCamera: Projection") ]	public float	FreeCamFov			{ set; get; }
		[ Description("Camera Z-far") ]
		[ Category("FreeCamera: Projection") ]	public float	FreeCamZFar			{ set; get; }
		[ Category("FreeCamera: Projection") ]	public float	FreeCamZNear		{ set; get; }
		[ Category("FreeCamera: Controls") ]	public float	FreeCamVelocity		{ set; get; }
		[ Category("FreeCamera: Controls") ]	public float	FreeCamSensitivity	{ set; get; }
		[ Category("FreeCamera: Controls") ]	public bool		FreeCamInvertMouse	{ set; get; }
		[ Category("FreeCamera: Controls") ]	public Keys		FreeCamMoveForward	{ set; get; }
		[ Category("FreeCamera: Controls") ]	public Keys		FreeCamMoveBackward	{ set; get; }
		[ Category("FreeCamera: Controls") ]	public Keys		FreeCamMoveLeft		{ set; get; }
		[ Category("FreeCamera: Controls") ]	public Keys		FreeCamMoveRight	{ set; get; }
		[ Category("FreeCamera: Controls") ]	public Keys		FreeCamMoveUp		{ set; get; }
		[ Category("FreeCamera: Controls") ]	public Keys		FreeCamMoveDown		{ set; get; }
		[ Category("FreeCamera: Controls") ]	public float	FreeCamGamepadSensitivity	{ set; get; }
		[ Category("FreeCamera: Controls") ]	public bool		FreeCamGamepadInvert		{ set; get; }

		[ Category("FreeCamera: Stereo") ]		public float	FreeCamStereoSeparation		{ set; get; }
		[ Category("FreeCamera: Stereo") ]		public float	FreeCamStereoConvergence	{ set; get; }
		public Color LenaColor { get; set; }


		public UIConfig()
		{
			LenaColor			=	Color.White;
			FreeCamEnabled		=	false;
			FreeCamFov			=	90;
			FreeCamVelocity		=	10;
			FreeCamSensitivity	=	0.1f;
			FreeCamInvertMouse	=	false;
			FreeCamMoveForward	=	Keys.W;
			FreeCamMoveBackward	=	Keys.S;
			FreeCamMoveLeft		=	Keys.A;
			FreeCamMoveRight	=	Keys.D;
			FreeCamMoveUp		=	Keys.Space;
			FreeCamMoveDown		=	Keys.C;
			FreeCamZFar			=	5000;
			FreeCamZNear		=	0.1f;

			FreeCamGamepadInvert		=	false;
			FreeCamGamepadSensitivity	=	90;

			FreeCamStereoSeparation		=	0.5f;
			FreeCamStereoConvergence	=	10.0f;
		}
	}
}
