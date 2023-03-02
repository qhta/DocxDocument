namespace DocumentModel.UI;

/// <summary>
///   Defines the ContextualTabSet Class.
/// </summary>
public record ContextualTabSet
{
  /// <summary>
  ///   idMso
  /// </summary>
  public String? IdMso { get; set; }

  /// <summary>
  ///   visible
  /// </summary>
  public Boolean? Visible { get; set; }

  /// <summary>
  ///   getVisible
  /// </summary>
  public String? GetVisible { get; set; }

  public Collection<Tab>? Tabs { get; set; }
}