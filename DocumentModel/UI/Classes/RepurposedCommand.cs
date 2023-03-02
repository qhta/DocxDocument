namespace DocumentModel.UI;

/// <summary>
///   Defines the RepurposedCommand Class.
/// </summary>
public record RepurposedCommand
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