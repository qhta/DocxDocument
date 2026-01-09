namespace DocumentModel;

/// <summary>
/// Represents the Office ribbon interface, supporting custom tabs, contextual tabs, and Quick Access Toolbar customization for advanced Office UI scenarios.
/// </summary>
/// <remarks>
/// This interface defines the ribbon structure for Office applications, enabling customization of tabs, contextual tabs, and the Quick Access Toolbar. It supports starting from a blank ribbon, adding custom tabs, and integrating contextual tab sets for dynamic UI experiences. The interface provides access to all major ribbon components for comprehensive Office add-in or document integration.
/// </remarks>
public interface Ribbon
{
  /// <summary>
  /// Indicates whether to start with a blank ribbon, removing all built-in tabs and controls.
  /// </summary>
  public bool? StartFromScratch { get; set; }

  /// <summary>
  /// Quick Access Toolbar customization for the ribbon.
  /// </summary>
  public QuickAccessToolbar? QuickAccessToolbar { get; set; }

  /// <summary>
  /// Collection of custom and built-in tabs in the ribbon.
  /// </summary>
  public Tabs? Tabs { get; set; }

  /// <summary>
  /// Collection of contextual tab sets for dynamic ribbon scenarios.
  /// </summary>
  public TabSetCollection? ContextualTabs { get; set; }
}