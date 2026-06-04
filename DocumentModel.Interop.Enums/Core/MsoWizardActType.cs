namespace DocumentModel.Interop.Core;

/// <summary>
/// This object, member, or enumeration is deprecated and is not intended to be used in your code.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msowizardacttype?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType(typeof(Microsoft.Office.Core.MsoWizardActType))]
public enum WizardActType
{
  /// <summary>
  /// This object, member, or enumeration is deprecated and is not intended to be used in your code.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoWizardActType.msoWizardActInactive))]
  Inactive,
  /// <summary>
  /// This object, member, or enumeration is deprecated and is not intended to be used in your code.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoWizardActType.msoWizardActActive))]
  Active,
  /// <summary>
  /// This object, member, or enumeration is deprecated and is not intended to be used in your code.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoWizardActType.msoWizardActSuspend))]
  Suspend,
  /// <summary>
  /// This object, member, or enumeration is deprecated and is not intended to be used in your code.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoWizardActType.msoWizardActResume))]
  Resume
}
