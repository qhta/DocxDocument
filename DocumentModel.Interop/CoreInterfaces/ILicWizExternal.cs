using System;

namespace DocumentModel.Interop.Core;

public partial interface ILicWizExternal
{
  public int Context { get; }
  public object Validator { get; }
  public object LicAgent { get; }
  public string CountryInfo { get; }
  public int WizardVisible { set; }
  public string WizardTitle { set; }
  public int AnimationEnabled { get; }
  public int CurrentHelpId { set; }
  public string OfficeOnTheWebUrl { get; }
}
