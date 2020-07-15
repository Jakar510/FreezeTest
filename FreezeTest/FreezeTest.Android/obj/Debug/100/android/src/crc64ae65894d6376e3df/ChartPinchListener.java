package crc64ae65894d6376e3df;


public class ChartPinchListener
	extends android.view.ScaleGestureDetector.SimpleOnScaleGestureListener
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onScale:(Landroid/view/ScaleGestureDetector;)Z:GetOnScale_Landroid_view_ScaleGestureDetector_Handler\n" +
			"";
		mono.android.Runtime.register ("Steema.TeeChart.ChartPinchListener, TeeChart.PCL.Android", ChartPinchListener.class, __md_methods);
	}


	public ChartPinchListener ()
	{
		super ();
		if (getClass () == ChartPinchListener.class)
			mono.android.TypeManager.Activate ("Steema.TeeChart.ChartPinchListener, TeeChart.PCL.Android", "", this, new java.lang.Object[] {  });
	}

	public ChartPinchListener (crc64ae65894d6376e3df.TChart p0)
	{
		super ();
		if (getClass () == ChartPinchListener.class)
			mono.android.TypeManager.Activate ("Steema.TeeChart.ChartPinchListener, TeeChart.PCL.Android", "Steema.TeeChart.TChart, TeeChart.PCL.Android", this, new java.lang.Object[] { p0 });
	}


	public boolean onScale (android.view.ScaleGestureDetector p0)
	{
		return n_onScale (p0);
	}

	private native boolean n_onScale (android.view.ScaleGestureDetector p0);

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
