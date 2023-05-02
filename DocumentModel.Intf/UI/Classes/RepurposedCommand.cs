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
  public string? OnAction { get; set; }

  /// <summary>
  ///   enabled
  /// </summary>
  public bool? Enabled { get; set; }

  /// <summary>
  ///   getEnabled
  /// </summary>
  public string? GetEnabled { get; set; }

  /// <summary>
  ///   idMso
  /// </summary>
  public string? IdMso { get; set; }
}