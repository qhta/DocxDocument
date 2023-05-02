namespace DocumentModel;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the TabSet Class.
/// </summary>
public class TabSet: ModelElement
{
  /// <summary>
  ///   idMso, this property is only available in Office 2010 and later.
  /// </summary>
  public string? IdMso { get; set; }

  /// <summary>
  ///   visible, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? Visible { get; set; }

  /// <summary>
  ///   getVisible, this property is only available in Office 2010 and later.
  /// </summary>
  public string? GetVisible { get; set; }

  public Collection<Tab>? Tabs { get; set; }
}