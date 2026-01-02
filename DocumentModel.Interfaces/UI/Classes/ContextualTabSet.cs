namespace DocumentModel.UI;

/// <summary>
///   Defines the ContextualTabSet Class.
/// </summary>
public class ContextualTabSet: ModelElement
{
  /// <summary>
  ///   idMso
  /// </summary>
  public string? IdMso { get; set; }
  /// <summary>
  ///   visible
  /// </summary>
  public bool? Visible { get; set; }
  /// <summary>
  ///   getVisible
  /// </summary>
  public string? GetVisible { get; set; }
  public Collection<Tab>? Tabs { get; set; }
}