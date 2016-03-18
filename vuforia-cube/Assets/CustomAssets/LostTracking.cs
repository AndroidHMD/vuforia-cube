using UnityEngine;

namespace Vuforia
{
	public class LostTracking : MonoBehaviour
	{
		public Cardboard myCardboard;
		public Camera myCamera;


		#region PRIVATE_MEMBER_VARIABLES

		private Transform lastTransform;
		private Pose3D lastPose;

		#endregion // PRIVATE_MEMBER_VARIABLES

		void update ()
		{
			var rot = Cardboard.SDK.HeadPose.Orientation;
			if (myCardboard.TrackingFound) 
			{
				//lastTransform = myCardboard.transform;
				lastTransform = myCamera.transform;
				lastPose = myCardboard.HeadPose;

				Debug.Log("FoundTracking");
			}
			else //!myCardboard.TrackingFound
			{
				transform.position = lastTransform.position;
				//transform.rotation = myCardboard.transform.localRotation;
				transform.rotation = rot;

				//transform.position = lastPose.Position;
				//transform.rotation = myCardboard.HeadPose.Orientation;
				Debug.Log("LostTracking");
			}

		}
	}
}

