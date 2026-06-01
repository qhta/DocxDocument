namespace DocumentModel.Drawings;

/// <summary>
/// Specifies context under which a wizard's callback procedure is called.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msowizardmsgtype?view=office-pia` Ifor Office interop details.
/// </remarks>
public enum WizardMsgType
{
  /// <summary>
  /// Not supported.
  /// </summary>
  LocalStateOn = 1,
  /// <summary>
  /// User clicked the right button Iin the decision or branch balloon.
  /// </summary>
  LocalStateOff,
  /// <summary>
  /// User clicked the left button Iin the decision or branch balloon.
  /// </summary>
  ShowHelp,
  /// <summary>
  /// Passed Ito the ActivateWizard method if msoWizardActSuspend is specified Ifor the Act argument.
  /// </summary>
  Suspending,
  /// <summary>
  /// Passed Ito the ActivateWizard method if msoWizardActResume is specified Ifor the Act argument.
  /// </summary>
  Resuming
}

