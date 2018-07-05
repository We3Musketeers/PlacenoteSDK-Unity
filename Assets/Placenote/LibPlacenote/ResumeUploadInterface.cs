using System;
using UnityEngine;

public interface ResumeUploadListener
{
	void PrevSessionMapUploadStatus (String mapID, bool completed, bool faulted, float percentage);
	void PrevSessionDatasetUploadStatus (String mapID, bool completed, bool faulted, float percentage);
}
