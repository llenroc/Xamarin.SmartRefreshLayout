using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Scwang.Smartrefresh.Layout.Footer {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.scwang.smartrefresh.layout.footer']/class[@name='ClassicsFooter']"
	[global::Android.Runtime.Register ("com/scwang/smartrefresh/layout/footer/ClassicsFooter", DoNotGenerateAcw=true)]
	public partial class ClassicsFooter : global::Android.Widget.LinearLayout, global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshFooter {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout.footer']/class[@name='ClassicsFooter']/field[@name='REFRESH_FOOTER_ALLLOADED']"
		[Register ("REFRESH_FOOTER_ALLLOADED")]
		public static string RefreshFooterAllloaded {
			get {
				const string __id = "REFRESH_FOOTER_ALLLOADED.Ljava/lang/String;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "REFRESH_FOOTER_ALLLOADED.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout.footer']/class[@name='ClassicsFooter']/field[@name='REFRESH_FOOTER_FAILED']"
		[Register ("REFRESH_FOOTER_FAILED")]
		public static string RefreshFooterFailed {
			get {
				const string __id = "REFRESH_FOOTER_FAILED.Ljava/lang/String;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "REFRESH_FOOTER_FAILED.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout.footer']/class[@name='ClassicsFooter']/field[@name='REFRESH_FOOTER_FINISH']"
		[Register ("REFRESH_FOOTER_FINISH")]
		public static string RefreshFooterFinish {
			get {
				const string __id = "REFRESH_FOOTER_FINISH.Ljava/lang/String;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "REFRESH_FOOTER_FINISH.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout.footer']/class[@name='ClassicsFooter']/field[@name='REFRESH_FOOTER_LOADING']"
		[Register ("REFRESH_FOOTER_LOADING")]
		public static string RefreshFooterLoading {
			get {
				const string __id = "REFRESH_FOOTER_LOADING.Ljava/lang/String;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "REFRESH_FOOTER_LOADING.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout.footer']/class[@name='ClassicsFooter']/field[@name='REFRESH_FOOTER_PULLUP']"
		[Register ("REFRESH_FOOTER_PULLUP")]
		public static string RefreshFooterPullup {
			get {
				const string __id = "REFRESH_FOOTER_PULLUP.Ljava/lang/String;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "REFRESH_FOOTER_PULLUP.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.scwang.smartrefresh.layout.footer']/class[@name='ClassicsFooter']/field[@name='REFRESH_FOOTER_RELEASE']"
		[Register ("REFRESH_FOOTER_RELEASE")]
		public static string RefreshFooterRelease {
			get {
				const string __id = "REFRESH_FOOTER_RELEASE.Ljava/lang/String;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "REFRESH_FOOTER_RELEASE.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal            static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/scwang/smartrefresh/layout/footer/ClassicsFooter", typeof (ClassicsFooter));
		internal static IntPtr class_ref {
			get {
				return _members.JniPeerType.PeerReference.Handle;
			}
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected ClassicsFooter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.scwang.smartrefresh.layout.footer']/class[@name='ClassicsFooter']/constructor[@name='ClassicsFooter' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe ClassicsFooter (global::Android.Content.Context context)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.scwang.smartrefresh.layout.footer']/class[@name='ClassicsFooter']/constructor[@name='ClassicsFooter' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe ClassicsFooter (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Landroid/util/AttributeSet;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((attrs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) attrs).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.scwang.smartrefresh.layout.footer']/class[@name='ClassicsFooter']/constructor[@name='ClassicsFooter' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe ClassicsFooter (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs, int defStyleAttr)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Landroid/util/AttributeSet;I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((attrs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) attrs).Handle);
				__args [2] = new JniArgumentValue (defStyleAttr);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_isSupportHorizontalDrag;
#pragma warning disable 0169
		static Delegate GetIsSupportHorizontalDragHandler ()
		{
			if (cb_isSupportHorizontalDrag == null)
				cb_isSupportHorizontalDrag = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsSupportHorizontalDrag);
			return cb_isSupportHorizontalDrag;
		}

		static bool n_IsSupportHorizontalDrag (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Scwang.Smartrefresh.Layout.Footer.ClassicsFooter __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Footer.ClassicsFooter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsSupportHorizontalDrag;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsSupportHorizontalDrag {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.footer']/class[@name='ClassicsFooter']/method[@name='isSupportHorizontalDrag' and count(parameter)=0]"
			[Register ("isSupportHorizontalDrag", "()Z", "GetIsSupportHorizontalDragHandler")]
			get {
				const string __id = "isSupportHorizontalDrag.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getSpinnerStyle;
#pragma warning disable 0169
		static Delegate GetGetSpinnerStyleHandler ()
		{
			if (cb_getSpinnerStyle == null)
				cb_getSpinnerStyle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSpinnerStyle);
			return cb_getSpinnerStyle;
		}

		static IntPtr n_GetSpinnerStyle (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Scwang.Smartrefresh.Layout.Footer.ClassicsFooter __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Footer.ClassicsFooter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SpinnerStyle);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Scwang.Smartrefresh.Layout.Constant.SpinnerStyle SpinnerStyle {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.footer']/class[@name='ClassicsFooter']/method[@name='getSpinnerStyle' and count(parameter)=0]"
			[Register ("getSpinnerStyle", "()Lcom/scwang/smartrefresh/layout/constant/SpinnerStyle;", "GetGetSpinnerStyleHandler")]
			get {
				const string __id = "getSpinnerStyle.()Lcom/scwang/smartrefresh/layout/constant/SpinnerStyle;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Constant.SpinnerStyle> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getView;
#pragma warning disable 0169
		static Delegate GetGetViewHandler ()
		{
			if (cb_getView == null)
				cb_getView = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetView);
			return cb_getView;
		}

		static IntPtr n_GetView (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Scwang.Smartrefresh.Layout.Footer.ClassicsFooter __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Footer.ClassicsFooter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.View);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Views.View View {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.footer']/class[@name='ClassicsFooter']/method[@name='getView' and count(parameter)=0]"
			[Register ("getView", "()Landroid/view/View;", "GetGetViewHandler")]
			get {
				const string __id = "getView.()Landroid/view/View;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Views.View> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_onFinish_Lcom_scwang_smartrefresh_layout_api_RefreshLayout_Z;
#pragma warning disable 0169
		static Delegate GetOnFinish_Lcom_scwang_smartrefresh_layout_api_RefreshLayout_ZHandler ()
		{
			if (cb_onFinish_Lcom_scwang_smartrefresh_layout_api_RefreshLayout_Z == null)
				cb_onFinish_Lcom_scwang_smartrefresh_layout_api_RefreshLayout_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool, int>) n_OnFinish_Lcom_scwang_smartrefresh_layout_api_RefreshLayout_Z);
			return cb_onFinish_Lcom_scwang_smartrefresh_layout_api_RefreshLayout_Z;
		}

		static int n_OnFinish_Lcom_scwang_smartrefresh_layout_api_RefreshLayout_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_layout, bool success)
		{
			global::Com.Scwang.Smartrefresh.Layout.Footer.ClassicsFooter __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Footer.ClassicsFooter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout layout = (global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout)global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (native_layout, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.OnFinish (layout, success);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.footer']/class[@name='ClassicsFooter']/method[@name='onFinish' and count(parameter)=2 and parameter[1][@type='com.scwang.smartrefresh.layout.api.RefreshLayout'] and parameter[2][@type='boolean']]"
		[Register ("onFinish", "(Lcom/scwang/smartrefresh/layout/api/RefreshLayout;Z)I", "GetOnFinish_Lcom_scwang_smartrefresh_layout_api_RefreshLayout_ZHandler")]
		public virtual unsafe int OnFinish (global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout layout, bool success)
		{
			const string __id = "onFinish.(Lcom/scwang/smartrefresh/layout/api/RefreshLayout;Z)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((layout == null) ? IntPtr.Zero : ((global::Java.Lang.Object) layout).Handle);
				__args [1] = new JniArgumentValue (success);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_onHorizontalDrag_FII;
#pragma warning disable 0169
		static Delegate GetOnHorizontalDrag_FIIHandler ()
		{
			if (cb_onHorizontalDrag_FII == null)
				cb_onHorizontalDrag_FII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, int, int>) n_OnHorizontalDrag_FII);
			return cb_onHorizontalDrag_FII;
		}

		static void n_OnHorizontalDrag_FII (IntPtr jnienv, IntPtr native__this, float percentX, int offsetX, int offsetMax)
		{
			global::Com.Scwang.Smartrefresh.Layout.Footer.ClassicsFooter __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Footer.ClassicsFooter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnHorizontalDrag (percentX, offsetX, offsetMax);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.footer']/class[@name='ClassicsFooter']/method[@name='onHorizontalDrag' and count(parameter)=3 and parameter[1][@type='float'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("onHorizontalDrag", "(FII)V", "GetOnHorizontalDrag_FIIHandler")]
		public virtual unsafe void OnHorizontalDrag (float percentX, int offsetX, int offsetMax)
		{
			const string __id = "onHorizontalDrag.(FII)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (percentX);
				__args [1] = new JniArgumentValue (offsetX);
				__args [2] = new JniArgumentValue (offsetMax);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onInitialized_Lcom_scwang_smartrefresh_layout_api_RefreshKernel_II;
#pragma warning disable 0169
		static Delegate GetOnInitialized_Lcom_scwang_smartrefresh_layout_api_RefreshKernel_IIHandler ()
		{
			if (cb_onInitialized_Lcom_scwang_smartrefresh_layout_api_RefreshKernel_II == null)
				cb_onInitialized_Lcom_scwang_smartrefresh_layout_api_RefreshKernel_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int>) n_OnInitialized_Lcom_scwang_smartrefresh_layout_api_RefreshKernel_II);
			return cb_onInitialized_Lcom_scwang_smartrefresh_layout_api_RefreshKernel_II;
		}

		static void n_OnInitialized_Lcom_scwang_smartrefresh_layout_api_RefreshKernel_II (IntPtr jnienv, IntPtr native__this, IntPtr native_kernel, int height, int extendHeight)
		{
			global::Com.Scwang.Smartrefresh.Layout.Footer.ClassicsFooter __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Footer.ClassicsFooter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel kernel = (global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel)global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel> (native_kernel, JniHandleOwnership.DoNotTransfer);
			__this.OnInitialized (kernel, height, extendHeight);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.footer']/class[@name='ClassicsFooter']/method[@name='onInitialized' and count(parameter)=3 and parameter[1][@type='com.scwang.smartrefresh.layout.api.RefreshKernel'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("onInitialized", "(Lcom/scwang/smartrefresh/layout/api/RefreshKernel;II)V", "GetOnInitialized_Lcom_scwang_smartrefresh_layout_api_RefreshKernel_IIHandler")]
		public virtual unsafe void OnInitialized (global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshKernel kernel, int height, int extendHeight)
		{
			const string __id = "onInitialized.(Lcom/scwang/smartrefresh/layout/api/RefreshKernel;II)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((kernel == null) ? IntPtr.Zero : ((global::Java.Lang.Object) kernel).Handle);
				__args [1] = new JniArgumentValue (height);
				__args [2] = new JniArgumentValue (extendHeight);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onPullReleasing_FIII;
#pragma warning disable 0169
		static Delegate GetOnPullReleasing_FIIIHandler ()
		{
			if (cb_onPullReleasing_FIII == null)
				cb_onPullReleasing_FIII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, int, int, int>) n_OnPullReleasing_FIII);
			return cb_onPullReleasing_FIII;
		}

		static void n_OnPullReleasing_FIII (IntPtr jnienv, IntPtr native__this, float percent, int offset, int headHeight, int extendHeight)
		{
			global::Com.Scwang.Smartrefresh.Layout.Footer.ClassicsFooter __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Footer.ClassicsFooter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnPullReleasing (percent, offset, headHeight, extendHeight);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.footer']/class[@name='ClassicsFooter']/method[@name='onPullReleasing' and count(parameter)=4 and parameter[1][@type='float'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("onPullReleasing", "(FIII)V", "GetOnPullReleasing_FIIIHandler")]
		public virtual unsafe void OnPullReleasing (float percent, int offset, int headHeight, int extendHeight)
		{
			const string __id = "onPullReleasing.(FIII)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (percent);
				__args [1] = new JniArgumentValue (offset);
				__args [2] = new JniArgumentValue (headHeight);
				__args [3] = new JniArgumentValue (extendHeight);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onPullingUp_FIII;
#pragma warning disable 0169
		static Delegate GetOnPullingUp_FIIIHandler ()
		{
			if (cb_onPullingUp_FIII == null)
				cb_onPullingUp_FIII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, int, int, int>) n_OnPullingUp_FIII);
			return cb_onPullingUp_FIII;
		}

		static void n_OnPullingUp_FIII (IntPtr jnienv, IntPtr native__this, float percent, int offset, int footerHeight, int extendHeight)
		{
			global::Com.Scwang.Smartrefresh.Layout.Footer.ClassicsFooter __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Footer.ClassicsFooter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnPullingUp (percent, offset, footerHeight, extendHeight);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.footer']/class[@name='ClassicsFooter']/method[@name='onPullingUp' and count(parameter)=4 and parameter[1][@type='float'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("onPullingUp", "(FIII)V", "GetOnPullingUp_FIIIHandler")]
		public virtual unsafe void OnPullingUp (float percent, int offset, int footerHeight, int extendHeight)
		{
			const string __id = "onPullingUp.(FIII)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (percent);
				__args [1] = new JniArgumentValue (offset);
				__args [2] = new JniArgumentValue (footerHeight);
				__args [3] = new JniArgumentValue (extendHeight);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onStartAnimator_Lcom_scwang_smartrefresh_layout_api_RefreshLayout_II;
#pragma warning disable 0169
		static Delegate GetOnStartAnimator_Lcom_scwang_smartrefresh_layout_api_RefreshLayout_IIHandler ()
		{
			if (cb_onStartAnimator_Lcom_scwang_smartrefresh_layout_api_RefreshLayout_II == null)
				cb_onStartAnimator_Lcom_scwang_smartrefresh_layout_api_RefreshLayout_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int>) n_OnStartAnimator_Lcom_scwang_smartrefresh_layout_api_RefreshLayout_II);
			return cb_onStartAnimator_Lcom_scwang_smartrefresh_layout_api_RefreshLayout_II;
		}

		static void n_OnStartAnimator_Lcom_scwang_smartrefresh_layout_api_RefreshLayout_II (IntPtr jnienv, IntPtr native__this, IntPtr native_layout, int headHeight, int extendHeight)
		{
			global::Com.Scwang.Smartrefresh.Layout.Footer.ClassicsFooter __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Footer.ClassicsFooter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout layout = (global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout)global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (native_layout, JniHandleOwnership.DoNotTransfer);
			__this.OnStartAnimator (layout, headHeight, extendHeight);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.footer']/class[@name='ClassicsFooter']/method[@name='onStartAnimator' and count(parameter)=3 and parameter[1][@type='com.scwang.smartrefresh.layout.api.RefreshLayout'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("onStartAnimator", "(Lcom/scwang/smartrefresh/layout/api/RefreshLayout;II)V", "GetOnStartAnimator_Lcom_scwang_smartrefresh_layout_api_RefreshLayout_IIHandler")]
		public virtual unsafe void OnStartAnimator (global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout layout, int headHeight, int extendHeight)
		{
			const string __id = "onStartAnimator.(Lcom/scwang/smartrefresh/layout/api/RefreshLayout;II)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((layout == null) ? IntPtr.Zero : ((global::Java.Lang.Object) layout).Handle);
				__args [1] = new JniArgumentValue (headHeight);
				__args [2] = new JniArgumentValue (extendHeight);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onStateChanged_Lcom_scwang_smartrefresh_layout_api_RefreshLayout_Lcom_scwang_smartrefresh_layout_constant_RefreshState_Lcom_scwang_smartrefresh_layout_constant_RefreshState_;
#pragma warning disable 0169
		static Delegate GetOnStateChanged_Lcom_scwang_smartrefresh_layout_api_RefreshLayout_Lcom_scwang_smartrefresh_layout_constant_RefreshState_Lcom_scwang_smartrefresh_layout_constant_RefreshState_Handler ()
		{
			if (cb_onStateChanged_Lcom_scwang_smartrefresh_layout_api_RefreshLayout_Lcom_scwang_smartrefresh_layout_constant_RefreshState_Lcom_scwang_smartrefresh_layout_constant_RefreshState_ == null)
				cb_onStateChanged_Lcom_scwang_smartrefresh_layout_api_RefreshLayout_Lcom_scwang_smartrefresh_layout_constant_RefreshState_Lcom_scwang_smartrefresh_layout_constant_RefreshState_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_OnStateChanged_Lcom_scwang_smartrefresh_layout_api_RefreshLayout_Lcom_scwang_smartrefresh_layout_constant_RefreshState_Lcom_scwang_smartrefresh_layout_constant_RefreshState_);
			return cb_onStateChanged_Lcom_scwang_smartrefresh_layout_api_RefreshLayout_Lcom_scwang_smartrefresh_layout_constant_RefreshState_Lcom_scwang_smartrefresh_layout_constant_RefreshState_;
		}

		static void n_OnStateChanged_Lcom_scwang_smartrefresh_layout_api_RefreshLayout_Lcom_scwang_smartrefresh_layout_constant_RefreshState_Lcom_scwang_smartrefresh_layout_constant_RefreshState_ (IntPtr jnienv, IntPtr native__this, IntPtr native_refreshLayout, IntPtr native_oldState, IntPtr native_newState)
		{
			global::Com.Scwang.Smartrefresh.Layout.Footer.ClassicsFooter __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Footer.ClassicsFooter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout refreshLayout = (global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout)global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout> (native_refreshLayout, JniHandleOwnership.DoNotTransfer);
			global::Com.Scwang.Smartrefresh.Layout.Constant.RefreshState oldState = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Constant.RefreshState> (native_oldState, JniHandleOwnership.DoNotTransfer);
			global::Com.Scwang.Smartrefresh.Layout.Constant.RefreshState newState = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Constant.RefreshState> (native_newState, JniHandleOwnership.DoNotTransfer);
			__this.OnStateChanged (refreshLayout, oldState, newState);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.footer']/class[@name='ClassicsFooter']/method[@name='onStateChanged' and count(parameter)=3 and parameter[1][@type='com.scwang.smartrefresh.layout.api.RefreshLayout'] and parameter[2][@type='com.scwang.smartrefresh.layout.constant.RefreshState'] and parameter[3][@type='com.scwang.smartrefresh.layout.constant.RefreshState']]"
		[Register ("onStateChanged", "(Lcom/scwang/smartrefresh/layout/api/RefreshLayout;Lcom/scwang/smartrefresh/layout/constant/RefreshState;Lcom/scwang/smartrefresh/layout/constant/RefreshState;)V", "GetOnStateChanged_Lcom_scwang_smartrefresh_layout_api_RefreshLayout_Lcom_scwang_smartrefresh_layout_constant_RefreshState_Lcom_scwang_smartrefresh_layout_constant_RefreshState_Handler")]
		public virtual unsafe void OnStateChanged (global::Com.Scwang.Smartrefresh.Layout.Api.IRefreshLayout refreshLayout, global::Com.Scwang.Smartrefresh.Layout.Constant.RefreshState oldState, global::Com.Scwang.Smartrefresh.Layout.Constant.RefreshState newState)
		{
			const string __id = "onStateChanged.(Lcom/scwang/smartrefresh/layout/api/RefreshLayout;Lcom/scwang/smartrefresh/layout/constant/RefreshState;Lcom/scwang/smartrefresh/layout/constant/RefreshState;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((refreshLayout == null) ? IntPtr.Zero : ((global::Java.Lang.Object) refreshLayout).Handle);
				__args [1] = new JniArgumentValue ((oldState == null) ? IntPtr.Zero : ((global::Java.Lang.Object) oldState).Handle);
				__args [2] = new JniArgumentValue ((newState == null) ? IntPtr.Zero : ((global::Java.Lang.Object) newState).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setAccentColor_I;
#pragma warning disable 0169
		static Delegate GetSetAccentColor_IHandler ()
		{
			if (cb_setAccentColor_I == null)
				cb_setAccentColor_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetAccentColor_I);
			return cb_setAccentColor_I;
		}

		static IntPtr n_SetAccentColor_I (IntPtr jnienv, IntPtr native__this, int accentColor)
		{
			global::Com.Scwang.Smartrefresh.Layout.Footer.ClassicsFooter __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Footer.ClassicsFooter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetAccentColor (accentColor));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.footer']/class[@name='ClassicsFooter']/method[@name='setAccentColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setAccentColor", "(I)Lcom/scwang/smartrefresh/layout/footer/ClassicsFooter;", "GetSetAccentColor_IHandler")]
		public virtual unsafe global::Com.Scwang.Smartrefresh.Layout.Footer.ClassicsFooter SetAccentColor (int accentColor)
		{
			const string __id = "setAccentColor.(I)Lcom/scwang/smartrefresh/layout/footer/ClassicsFooter;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (accentColor);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Footer.ClassicsFooter> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setLoadmoreFinished_Z;
#pragma warning disable 0169
		static Delegate GetSetLoadmoreFinished_ZHandler ()
		{
			if (cb_setLoadmoreFinished_Z == null)
				cb_setLoadmoreFinished_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, bool>) n_SetLoadmoreFinished_Z);
			return cb_setLoadmoreFinished_Z;
		}

		static bool n_SetLoadmoreFinished_Z (IntPtr jnienv, IntPtr native__this, bool finished)
		{
			global::Com.Scwang.Smartrefresh.Layout.Footer.ClassicsFooter __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Footer.ClassicsFooter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SetLoadmoreFinished (finished);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.footer']/class[@name='ClassicsFooter']/method[@name='setLoadmoreFinished' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setLoadmoreFinished", "(Z)Z", "GetSetLoadmoreFinished_ZHandler")]
		public virtual unsafe bool SetLoadmoreFinished (bool finished)
		{
			const string __id = "setLoadmoreFinished.(Z)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (finished);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_setPrimaryColors_arrayI;
#pragma warning disable 0169
		static Delegate GetSetPrimaryColors_arrayIHandler ()
		{
			if (cb_setPrimaryColors_arrayI == null)
				cb_setPrimaryColors_arrayI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPrimaryColors_arrayI);
			return cb_setPrimaryColors_arrayI;
		}

		static void n_SetPrimaryColors_arrayI (IntPtr jnienv, IntPtr native__this, IntPtr native_colors)
		{
			global::Com.Scwang.Smartrefresh.Layout.Footer.ClassicsFooter __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Footer.ClassicsFooter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			int[] colors = (int[]) JNIEnv.GetArray (native_colors, JniHandleOwnership.DoNotTransfer, typeof (int));
			__this.SetPrimaryColors (colors);
			if (colors != null)
				JNIEnv.CopyArray (colors, native_colors);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.footer']/class[@name='ClassicsFooter']/method[@name='setPrimaryColors' and count(parameter)=1 and parameter[1][@type='int...']]"
		[Register ("setPrimaryColors", "([I)V", "GetSetPrimaryColors_arrayIHandler")]
		public virtual unsafe void SetPrimaryColors (params  int[] colors)
		{
			const string __id = "setPrimaryColors.([I)V";
			IntPtr native_colors = JNIEnv.NewArray (colors);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_colors);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (colors != null) {
					JNIEnv.CopyArray (native_colors, colors);
					JNIEnv.DeleteLocalRef (native_colors);
				}
			}
		}

		static Delegate cb_setProgressBitmap_Landroid_graphics_Bitmap_;
#pragma warning disable 0169
		static Delegate GetSetProgressBitmap_Landroid_graphics_Bitmap_Handler ()
		{
			if (cb_setProgressBitmap_Landroid_graphics_Bitmap_ == null)
				cb_setProgressBitmap_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetProgressBitmap_Landroid_graphics_Bitmap_);
			return cb_setProgressBitmap_Landroid_graphics_Bitmap_;
		}

		static IntPtr n_SetProgressBitmap_Landroid_graphics_Bitmap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_bitmap)
		{
			global::Com.Scwang.Smartrefresh.Layout.Footer.ClassicsFooter __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Footer.ClassicsFooter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Bitmap bitmap = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_bitmap, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetProgressBitmap (bitmap));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.footer']/class[@name='ClassicsFooter']/method[@name='setProgressBitmap' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
		[Register ("setProgressBitmap", "(Landroid/graphics/Bitmap;)Lcom/scwang/smartrefresh/layout/footer/ClassicsFooter;", "GetSetProgressBitmap_Landroid_graphics_Bitmap_Handler")]
		public virtual unsafe global::Com.Scwang.Smartrefresh.Layout.Footer.ClassicsFooter SetProgressBitmap (global::Android.Graphics.Bitmap bitmap)
		{
			const string __id = "setProgressBitmap.(Landroid/graphics/Bitmap;)Lcom/scwang/smartrefresh/layout/footer/ClassicsFooter;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((bitmap == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bitmap).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Footer.ClassicsFooter> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setProgressDrawable_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
		static Delegate GetSetProgressDrawable_Landroid_graphics_drawable_Drawable_Handler ()
		{
			if (cb_setProgressDrawable_Landroid_graphics_drawable_Drawable_ == null)
				cb_setProgressDrawable_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetProgressDrawable_Landroid_graphics_drawable_Drawable_);
			return cb_setProgressDrawable_Landroid_graphics_drawable_Drawable_;
		}

		static IntPtr n_SetProgressDrawable_Landroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_drawable)
		{
			global::Com.Scwang.Smartrefresh.Layout.Footer.ClassicsFooter __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Footer.ClassicsFooter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable drawable = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_drawable, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetProgressDrawable (drawable));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.footer']/class[@name='ClassicsFooter']/method[@name='setProgressDrawable' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
		[Register ("setProgressDrawable", "(Landroid/graphics/drawable/Drawable;)Lcom/scwang/smartrefresh/layout/footer/ClassicsFooter;", "GetSetProgressDrawable_Landroid_graphics_drawable_Drawable_Handler")]
		public virtual unsafe global::Com.Scwang.Smartrefresh.Layout.Footer.ClassicsFooter SetProgressDrawable (global::Android.Graphics.Drawables.Drawable drawable)
		{
			const string __id = "setProgressDrawable.(Landroid/graphics/drawable/Drawable;)Lcom/scwang/smartrefresh/layout/footer/ClassicsFooter;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((drawable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) drawable).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Footer.ClassicsFooter> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setProgressResource_I;
#pragma warning disable 0169
		static Delegate GetSetProgressResource_IHandler ()
		{
			if (cb_setProgressResource_I == null)
				cb_setProgressResource_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetProgressResource_I);
			return cb_setProgressResource_I;
		}

		static IntPtr n_SetProgressResource_I (IntPtr jnienv, IntPtr native__this, int resId)
		{
			global::Com.Scwang.Smartrefresh.Layout.Footer.ClassicsFooter __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Footer.ClassicsFooter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetProgressResource (resId));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.footer']/class[@name='ClassicsFooter']/method[@name='setProgressResource' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setProgressResource", "(I)Lcom/scwang/smartrefresh/layout/footer/ClassicsFooter;", "GetSetProgressResource_IHandler")]
		public virtual unsafe global::Com.Scwang.Smartrefresh.Layout.Footer.ClassicsFooter SetProgressResource (int resId)
		{
			const string __id = "setProgressResource.(I)Lcom/scwang/smartrefresh/layout/footer/ClassicsFooter;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (resId);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Footer.ClassicsFooter> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setSpinnerStyle_Lcom_scwang_smartrefresh_layout_constant_SpinnerStyle_;
#pragma warning disable 0169
		static Delegate GetSetSpinnerStyle_Lcom_scwang_smartrefresh_layout_constant_SpinnerStyle_Handler ()
		{
			if (cb_setSpinnerStyle_Lcom_scwang_smartrefresh_layout_constant_SpinnerStyle_ == null)
				cb_setSpinnerStyle_Lcom_scwang_smartrefresh_layout_constant_SpinnerStyle_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetSpinnerStyle_Lcom_scwang_smartrefresh_layout_constant_SpinnerStyle_);
			return cb_setSpinnerStyle_Lcom_scwang_smartrefresh_layout_constant_SpinnerStyle_;
		}

		static IntPtr n_SetSpinnerStyle_Lcom_scwang_smartrefresh_layout_constant_SpinnerStyle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_style)
		{
			global::Com.Scwang.Smartrefresh.Layout.Footer.ClassicsFooter __this = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Footer.ClassicsFooter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Scwang.Smartrefresh.Layout.Constant.SpinnerStyle style = global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Constant.SpinnerStyle> (native_style, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetSpinnerStyle (style));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.scwang.smartrefresh.layout.footer']/class[@name='ClassicsFooter']/method[@name='setSpinnerStyle' and count(parameter)=1 and parameter[1][@type='com.scwang.smartrefresh.layout.constant.SpinnerStyle']]"
		[Register ("setSpinnerStyle", "(Lcom/scwang/smartrefresh/layout/constant/SpinnerStyle;)Lcom/scwang/smartrefresh/layout/footer/ClassicsFooter;", "GetSetSpinnerStyle_Lcom_scwang_smartrefresh_layout_constant_SpinnerStyle_Handler")]
		public virtual unsafe global::Com.Scwang.Smartrefresh.Layout.Footer.ClassicsFooter SetSpinnerStyle (global::Com.Scwang.Smartrefresh.Layout.Constant.SpinnerStyle style)
		{
			const string __id = "setSpinnerStyle.(Lcom/scwang/smartrefresh/layout/constant/SpinnerStyle;)Lcom/scwang/smartrefresh/layout/footer/ClassicsFooter;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((style == null) ? IntPtr.Zero : ((global::Java.Lang.Object) style).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Scwang.Smartrefresh.Layout.Footer.ClassicsFooter> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
