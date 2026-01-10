namespace DocumentModel.CustomUI;

/// <summary>
/// Represents a tab in the Office Backstage view, supporting dynamic state, flexible layout, and advanced callback integration for custom UI scenarios.
/// </summary>
/// <remarks>
/// This interface defines a Backstage tab with properties for identification, positioning, state, labeling, layout configuration, and group collections. It enables dynamic visibility, enabled state, labeling, and layout adjustments, supporting comprehensive customization of the Backstage experience in Office applications.
/// </remarks>
public interface BackstageTab: CustomUIControl, BuiltInObject, TaggedObject
{

  /// <summary>
  /// Enable interaction with the Backstage tab.
  /// </summary>
  public bool? Enabled { get; set; }

  /// <summary>
  /// Callback for dynamic enabled state.
  /// </summary>
  public string? GetEnabled { get; set; }

  /// <summary>
  /// Label text for the Backstage tab.
  /// </summary>
  public string? Label { get; set; }

  /// <summary>
  /// Callback for dynamic label text.
  /// </summary>
  public string? GetLabel { get; set; }

  /// <summary>
  /// Show the Backstage tab in the UI.
  /// </summary>
  public bool? Visible { get; set; }

  /// <summary>
  /// Callback for dynamic visibility.
  /// </summary>
  public string? GetVisible { get; set; }

  /// <summary>
  /// Keyboard shortcut (keytip) for accessing the Backstage tab.
  /// </summary>
  public string? Keytip { get; set; }

  /// <summary>
  /// Callback for dynamic keytip.
  /// </summary>
  public string? GetKeytip { get; set; }

  /// <summary>
  /// Title text for the Backstage tab.
  /// </summary>
  public string? Title { get; set; }

  /// <summary>
  /// Callback for dynamic title text.
  /// </summary>
  public string? GetTitle { get; set; }

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