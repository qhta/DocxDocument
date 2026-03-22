namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies context under which a wizard's callback procedure is called.
/// </summary>
public enum MsoWizardMsgType
{
  /// <summary>
  /// Not supported. msoWizardMsgLocalStateOff2 User clicked the right button in the decision or branch balloon.
  /// msoWizardMsgShowHelp3 User clicked the left button in the decision or branch balloon. msoWizardMsgSuspending4
  /// Passed to the ActivateWizard method if msoWizardActSuspend is specified for the Act argument.
  /// </summary>
  LocalStateOn = 1,
  /// <summary>
  /// Specifies context under which a wizard's callback procedure is called.
  /// </summary>
  LocalStateOff,
  /// <summary>
  /// Specifies context under which a wizard's callback procedure is called.
  /// </summary>
  ShowHelp,
  /// <summary>
  /// Specifies context under which a wizard's callback procedure is called.
  /// </summary>
  Suspending,
  /// <summary>
  /// Passed to the ActivateWizard method if msoWizardActResume is specified for the Act argument.
  /// </summary>
  Resuming
}
