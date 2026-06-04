namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies how to use the value specified in the ExtraInfo property of the FollowHyperlink method.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msoextrainfomethod?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType("MsoExtraInfoMethod")]
public enum ExtraInfoMethod
{
  /// <summary>
  /// The value specified in the ExtraInfo property is a string that is appended to the address.
  /// </summary>
  [OfficeInteropEnumValue("msoMethodGet")]
  Get,
  /// <summary>
  /// The value specified in the ExtraInfo property is posted as a string or byte array.
  /// </summary>
  [OfficeInteropEnumValue("msoMethodPost")]
  Post
}
