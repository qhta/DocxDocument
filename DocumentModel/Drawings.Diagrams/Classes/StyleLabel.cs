namespace DocumentModel.Drawings.Diagrams;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Style Label.
/// </summary>
public class StyleLabel: ModelElement
{
  /// <summary>
  ///   Style Name
  /// </summary>
  public string? Name { get; set; }

  /// <summary>
  ///   3-D Scene.
  /// </summary>
  public Scene3D? Scene3D { get; set; }

  /// <summary>
  ///   3-D Shape Properties.
  /// </summary>
  public Shape3D? Shape3D { get; set; }

  /// <summary>
  ///   Text Properties.
  /// </summary>
  public TextProperties? TextProperties { get; set; }

  /// <summary>
  ///   Shape Style.
  /// </summary>
  public Style? Style { get; set; }

  /// <summary>
  ///   ExtensionList.
  /// </summary>
  public ExtensionList? ExtensionList { get; set; }
}