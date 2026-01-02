namespace DocumentModel.UI;

/// <summary>
///   Defines the DocumentSpecificQuickAccessToolbarControls Class.
/// </summary>
public class DocumentSpecificQuickAccessToolbarControls: ModelElement
{
  public QuickAccessToolbarControlClone? QuickAccessToolbarControlClone { get; set; }
  public UnsizedButton? UnsizedButton { get; set; }
  public VerticalSeparator? VerticalSeparator { get; set; }
}