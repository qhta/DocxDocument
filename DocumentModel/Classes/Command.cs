namespace DocumentModel;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the Command Class.
/// </summary>
public class Command: ModelElement
{
  /// <summary>
  ///   onAction, this property is only available in Office 2010 and later.
  /// </summary>
  public String? OnAction { get; set; }

  /// <summary>
  ///   enabled, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? Enabled { get; set; }

  /// <summary>
  ///   getEnabled, this property is only available in Office 2010 and later.
  /// </summary>
  public String? GetEnabled { get; set; }

  /// <summary>
  ///   idMso, this property is only available in Office 2010 and later.
  /// </summary>
  public String? IdMso { get; set; }
}