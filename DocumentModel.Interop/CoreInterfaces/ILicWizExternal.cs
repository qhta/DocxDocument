using System;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Reserved for internal use.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicwizexternal?view=office-pia
/// </remarks>
public partial interface ILicWizExternal
{
  /// <summary>
  /// Gets or sets the `Context` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicwizexternal.context?view=office-pia
  /// </remarks>
  public int Context { get; }
  /// <summary>
  /// Gets the `Validator` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicwizexternal.validator?view=office-pia
  /// </remarks>
  public object Validator { get; }
  /// <summary>
  /// Gets the `LicAgent` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicwizexternal.licagent?view=office-pia
  /// </remarks>
  public object LicAgent { get; }
  /// <summary>
  /// Gets the `CountryInfo` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicwizexternal.countryinfo?view=office-pia
  /// </remarks>
  public string CountryInfo { get; }
  /// <summary>
  /// Sets whether the licensing wizard is visible.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicwizexternal.wizardvisible?view=office-pia
  /// </remarks>
  public int WizardVisible { set; }
  /// <summary>
  /// Sets the title of the licensing wizard.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicwizexternal.wizardtitle?view=office-pia
  /// </remarks>
  public string WizardTitle { set; }
  /// <summary>
  /// Gets the `AnimationEnabled` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicwizexternal.animationenabled?view=office-pia
  /// </remarks>
  public int AnimationEnabled { get; }
  /// <summary>
  /// Sets the current Help topic identifier.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicwizexternal.currenthelpid?view=office-pia
  /// </remarks>
  public int CurrentHelpId { set; }
  /// <summary>
  /// Gets the `OfficeOnTheWebUrl` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicwizexternal.officeontheweburl?view=office-pia
  /// </remarks>
  public string OfficeOnTheWebUrl { get; }
}
