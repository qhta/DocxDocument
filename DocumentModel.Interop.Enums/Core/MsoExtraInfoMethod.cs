namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies how to use the value specified in the ExtraInfo property of the FollowHyperlink method.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msoextrainfomethod?view=office-pia` for Office interop details.
/// </remarks>
public enum MsoExtraInfoMethod
{
  /// <summary>
  /// Specifies how to use the value specified in the ExtraInfo property of the FollowHyperlink method.
  /// </summary>
  Get,
  /// <summary>
  /// The value specified in the ExtraInfo property is posted as a string or byte array.
  /// </summary>
  Post
}
