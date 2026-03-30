using System;

namespace DocumentModel.Application;

/// <summary>
/// Reserved for internal use.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicwizexternal?view=office-pia"/>
public partial interface ILicWizExternal: IModelObject
{
  /// <summary>
  /// Gets or sets the `Context` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicwizexternal.context?view=office-pia"/>
  public int Context { get; }
  /// <summary>
  /// Gets the `Validator` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicwizexternal.validator?view=office-pia"/>
  public object Validator { get; }
  /// <summary>
  /// Gets the `LicAgent` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicwizexternal.licagent?view=office-pia"/>
  public object LicAgent { get; }
  /// <summary>
  /// Gets the `CountryInfo` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicwizexternal.countryinfo?view=office-pia"/>
  public string CountryInfo { get; }
  /// <summary>
  /// Sets whether the licensing wizard is visible.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicwizexternal.wizardvisible?view=office-pia"/>
  public int WizardVisible { set; }
  /// <summary>
  /// Sets the title of the licensing wizard.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicwizexternal.wizardtitle?view=office-pia"/>
  public string WizardTitle { set; }
  /// <summary>
  /// Gets the `AnimationEnabled` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicwizexternal.animationenabled?view=office-pia"/>
  public int AnimationEnabled { get; }
  /// <summary>
  /// Sets the current Help topic identifier.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicwizexternal.currenthelpid?view=office-pia"/>
  public int CurrentHelpId { set; }
  /// <summary>
  /// Gets the `OfficeOnTheWebUrl` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicwizexternal.officeontheweburl?view=office-pia"/>
  public string OfficeOnTheWebUrl { get; }
}

