using System;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Reserved for internal use.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicwizexternal?view=office-pia"/>
public partial class LicWizExternal
{
  /// <summary>
  /// Gets or sets the `Context` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicwizexternal.context?view=office-pia"/>
  public int Context { get; set; }
  /// <summary>
  /// Gets the `Validator` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicwizexternal.validator?view=office-pia"/>
  public object Validator { get; set; } = String.Empty;
  /// <summary>
  /// Gets the `LicAgent` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicwizexternal.licagent?view=office-pia"/>
  public object LicAgent { get; set; } = String.Empty;
  /// <summary>
  /// Gets the `CountryInfo` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicwizexternal.countryinfo?view=office-pia"/>
  public string CountryInfo { get; set; } = String.Empty;
  /// <summary>
  /// Sets whether the licensing wizard is visible.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicwizexternal.wizardvisible?view=office-pia"/>
  public int WizardVisible { get; set; }
  /// <summary>
  /// Sets the title of the licensing wizard.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicwizexternal.wizardtitle?view=office-pia"/>
  public string WizardTitle { get; set; } = String.Empty;
  /// <summary>
  /// Gets the `AnimationEnabled` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicwizexternal.animationenabled?view=office-pia"/>
  public int AnimationEnabled { get; set; }
  /// <summary>
  /// Sets the current Help topic identifier.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicwizexternal.currenthelpid?view=office-pia"/>
  public int CurrentHelpId { get; set; }
  /// <summary>
  /// Gets the `OfficeOnTheWebUrl` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicwizexternal.officeontheweburl?view=office-pia"/>
  public string OfficeOnTheWebUrl { get; set; } = String.Empty;
}


