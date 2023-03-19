namespace DocumentModel;

/// <summary>
///   Defines the TabSet Class.
/// </summary>
public class TabSet: ModelElement
{
  /// <summary>
  ///   idMso, this property is only available in Office 2010 and later.
  /// </summary>
  public String? IdMso { get; set; }

  /// <summary>
  ///   visible, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? Visible { get; set; }

  /// <summary>
  ///   getVisible, this property is only available in Office 2010 and later.
  /// </summary>
  public String? GetVisible { get; set; }

  public Collection<Tab>? Tabs { get; set; }
}