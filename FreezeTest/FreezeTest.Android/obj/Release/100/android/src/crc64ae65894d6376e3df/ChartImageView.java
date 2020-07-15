package crc64ae65894d6376e3df;


public class ChartImageView
	extends android.widget.ImageView
	implements
		mono.android.IGCUserPeer,
		android.view.View.OnTouchListener,
		android.view.View.OnLongClickListener,
		android.view.GestureDetector.OnDoubleTapListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_getImageMatrix:()Landroid/graphics/Matrix;:GetGetImageMatrixHandler\n" +
			"n_setImageMatrix:(Landroid/graphics/Matrix;)V:GetSetImageMatrix_Landroid_graphics_Matrix_Handler\n" +
			"n_onTouch:(Landroid/view/View;Landroid/view/MotionEvent;)Z:GetOnTouch_Landroid_view_View_Landroid_view_MotionEvent_Handler:Android.Views.View/IOnTouchListenerInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n" +
			"n_onLongClick:(Landroid/view/View;)Z:GetOnLongClick_Landroid_view_View_Handler:Android.Views.View/IOnLongClickListenerInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n" +
			"n_onDoubleTap:(Landroid/view/MotionEvent;)Z:GetOnDoubleTap_Landroid_view_MotionEvent_Handler:Android.Views.GestureDetector/IOnDoubleTapListenerInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n" +
			"n_onDoubleTapEvent:(Landroid/view/MotionEvent;)Z:GetOnDoubleTapEvent_Landroid_view_MotionEvent_Handler:Android.Views.GestureDetector/IOnDoubleTapListenerInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n" +
			"n_onSingleTapConfirmed:(Landroid/view/MotionEvent;)Z:GetOnSingleTapConfirmed_Landroid_view_MotionEvent_Handler:Android.Views.GestureDetector/IOnDoubleTapListenerInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n" +
			"";
		mono.android.Runtime.register ("Steema.TeeChart.ChartImageView, TeeChart.PCL.Android", ChartImageView.class, __md_methods);
	}


	public ChartImageView (android.content.Context p0)
	{
		super (p0);
		if (getClass () == ChartImageView.class)
			mono.android.TypeManager.Activate ("Steema.TeeChart.ChartImageView, TeeChart.PCL.Android", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
	}


	public ChartImageView (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == ChartImageView.class)
			mono.android.TypeManager.Activate ("Steema.TeeChart.ChartImageView, TeeChart.PCL.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android", this, new java.lang.Object[] { p0, p1 });
	}


	public ChartImageView (android.content.Context p0, android.util.AttributeSet p1, int p2)
	{
		super (p0, p1, p2);
		if (getClass () == ChartImageView.class)
			mono.android.TypeManager.Activate ("Steema.TeeChart.ChartImageView, TeeChart.PCL.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2 });
	}


	public android.graphics.Matrix getImageMatrix ()
	{
		return n_getImageMatrix ();
	}

	private native android.graphics.Matrix n_getImageMatrix ();


	public void setImageMatrix (android.graphics.Matrix p0)
	{
		n_setImageMatrix (p0);
	}

	private native void n_setImageMatrix (android.graphics.Matrix p0);


	public boolean onTouch (android.view.View p0, android.view.MotionEvent p1)
	{
		return n_onTouch (p0, p1);
	}

	private native boolean n_onTouch (android.view.View p0, android.view.MotionEvent p1);


	public boolean onLongClick (android.view.View p0)
	{
		return n_onLongClick (p0);
	}

	private native boolean n_onLongClick (android.view.View p0);


	public boolean onDoubleTap (android.view.MotionEvent p0)
	{
		return n_onDoubleTap (p0);
	}

	private native boolean n_onDoubleTap (android.view.MotionEvent p0);


	public boolean onDoubleTapEvent (android.view.MotionEvent p0)
	{
		return n_onDoubleTapEvent (p0);
	}

	private native boolean n_onDoubleTapEvent (android.view.MotionEvent p0);


	public boolean onSingleTapConfirmed (android.view.MotionEvent p0)
	{
		return n_onSingleTapConfirmed (p0);
	}

	private native boolean n_onSingleTapConfirmed (android.view.MotionEvent p0);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
