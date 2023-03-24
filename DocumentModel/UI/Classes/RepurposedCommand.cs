namespace DocumentModel.UI;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the RepurposedCommand Class.
/// </summary>
public class RepurposedCommand: ModelElement
{
  /// <summary>
  ///   onAction
  /// </summary>
  public String? OnAction { get; set; }

  /// <summary>
  ///   enabled
  /// </summary>
  public Boolean? Enabled { get; set; }

  /// <summary>
  ///   getEnabled
  /// </summary>
  public String? GetEnabled { get; set; }

  /// <summary>
  ///   idMso
  /// </summary>
  public String? IdMso { get; set; }
}