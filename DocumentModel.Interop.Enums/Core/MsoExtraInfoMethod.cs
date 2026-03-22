namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies how to use the value specified in the ExtraInfo property of the FollowHyperlink method.
/// </summary>
public enum MsoExtraInfoMethod
{
  /// <summary>
  /// Specifies how to use the value specified in the ExtraInfo property of the FollowHyperlink method.
  /// </summary>
  msoMethodGet,
  /// <summary>
  /// The value specified in the ExtraInfo property is posted as a string or byte array.
  /// </summary>
  msoMethodPost
}
