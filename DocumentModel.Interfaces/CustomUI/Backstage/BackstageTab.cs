namespace DocumentModel.CustomUI;

/// <summary>
/// Represents a tab in the Office Backstage view, supporting dynamic state, flexible layout, and advanced callback integration for custom UI scenarios.
/// </summary>
/// <remarks>
/// This interface defines a Backstage tab with properties for identification, positioning, state, labeling, layout configuration, and group collections. It enables dynamic visibility, enabled state, labeling, and layout adjustments, supporting comprehensive customization of the Backstage experience in Office applications.
/// </remarks>
public interface BackstageTab: CustomUIControl, BuiltInObject, TaggedObject,
  EnableControl, VisibleControl,
  LabelledControl,
  KeytipControl,
  TitleControl
{

  /// <summary>
  /// Percentage width of the first column in the Backstage layout.
  /// </summary>
  public Int64? ColumnWidthPercent { get; set; }

  /// <summary>
  /// Minimum width of the first column in the Backstage layout.
  /// </summary>
  public Int64? FirstColumnMinWidth { get; set; }

  /// <summary>
  /// Maximum width of the first column in the Backstage layout.
  /// </summary>
  public Int64? FirstColumnMaxWidth { get; set; }

  /// <summary>
  /// Minimum width of the second column in the Backstage layout.
  /// </summary>
  public Int64? SecondColumnMinWidth { get; set; }

  /// <summary>
  /// Maximum width of the second column in the Backstage layout.
  /// </summary>
  public Int64? SecondColumnMaxWidth { get; set; }

  /// <summary>
  /// Collection of Backstage groups displayed in the tab.
  /// </summary>
  public BackstageGroups? BackstageGroups { get; set; }

  /// <summary>
  /// Collection of simple groups displayed in the tab.
  /// </summary>
  public SimpleGroups? SimpleGroups { get; set; }
}