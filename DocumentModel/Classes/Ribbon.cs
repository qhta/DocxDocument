namespace DocumentModel;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the Ribbon Class.
/// </summary>
public class Ribbon: ModelElement
{
  /// <summary>
  ///   startFromScratch, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? StartFromScratch { get; set; }

  /// <summary>
  ///   QuickAccessToolbar.
  /// </summary>
  public QuickAccessToolbar? QuickAccessToolbar { get; set; }

  /// <summary>
  ///   Tabs.
  /// </summary>
  public Tabs? Tabs { get; set; }

  /// <summary>
  ///   ContextualTabs.
  /// </summary>
  public ContextualTabs? ContextualTabs { get; set; }
}