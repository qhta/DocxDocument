namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies context under which a wizard's callback procedure is called.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msowizardmsgtype?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.MsoWizardMsgType")]
public enum WizardMsgType
{
  /// <summary>
  /// Not supported.
  /// </summary>
  [InteropEnumValue("msoWizardMsgLocalStateOn")]
  LocalStateOn = 1,
  /// <summary>
  /// User clicked the right button in the decision or branch balloon.
  /// </summary>
  [InteropEnumValue("msoWizardMsgLocalStateOff")]
  LocalStateOff,
  /// <summary>
  /// User clicked the left button in the decision or branch balloon.
  /// </summary>
  [InteropEnumValue("msoWizardMsgShowHelp")]
  ShowHelp,
  /// <summary>
  /// Passed to the ActivateWizard method if msoWizardActSuspend is specified for the Act argument.
  /// </summary>
  [InteropEnumValue("msoWizardMsgSuspending")]
  Suspending,
  /// <summary>
  /// Passed to the ActivateWizard method if msoWizardActResume is specified for the Act argument.
  /// </summary>
  [InteropEnumValue("msoWizardMsgResuming")]
  Resuming
}
