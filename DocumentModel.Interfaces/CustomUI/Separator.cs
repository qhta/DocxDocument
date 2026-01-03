namespace DocumentModel;

/// <summary>
///   Represents a separator control that provides visual division between controls in the ribbon interface.
/// </summary>
/// <remarks>
///   This interface extends <see cref="IModelElement"/> and defines a visual divider used to organize
///   and separate groups of related controls within ribbon groups, button groups, and other containers.
///   Unlike <see cref="MenuSeparator"/> which is specifically designed for menu contexts, this separator
///   is used in broader ribbon scenarios. Separators improve visual organization and help users distinguish
///   between different functional areas of the ribbon. They support positioning relative to other controls
///   and can have their visibility controlled statically or dynamically through callbacks.
/// </remarks>
public interface Separator : IModelElement
{
  /// <summary>
  ///   Gets or sets the unique identifier for this separator.
  /// </summary>
  public string? Id { get; set; }

  /// <summary>
  ///   Gets or sets the qualified identifier for this separator.
  /// </summary>
  /// <remarks>
  ///   Use this when the identifier needs to be unique across multiple namespaces.
  /// </remarks>
  public string? QualifiedId { get; set; }

  /// <summary>
  ///   Gets or sets an arbitrary tag value for custom data storage.
  /// </summary>
  /// <remarks>
  ///   The tag can be used to store application-specific information associated with this separator.
  /// </remarks>
  public string? Tag { get; set; }

  /// <summary>
  ///   Gets or sets a value indicating whether the separator is visible.
  /// </summary>
  public bool? Visible { get; set; }

  /// <summary>
  ///   Gets or sets the name of a callback function that dynamically determines the separator's visibility.
  /// </summary>
  /// <remarks>
  ///   The callback function should return a boolean value indicating whether the separator should be visible.
  /// </remarks>
  public string? GetVisible { get; set; }

  /// <summary>
  ///   Gets or sets the Microsoft Office identifier after which this separator should be inserted.
  /// </summary>
  /// <remarks>
  ///   Use this to position the separator relative to a built-in control.
  /// </remarks>
  public string? InsertAfterMso { get; set; }

  /// <summary>
  ///   Gets or sets the Microsoft Office identifier before which this separator should be inserted.
  /// </summary>
  /// <remarks>
  ///   Use this to position the separator relative to a built-in control.
  /// </remarks>
  public string? InsertBeforeMso { get; set; }

  /// <summary>
  ///   Gets or sets the qualified identifier after which this separator should be inserted.
  /// </summary>
  /// <remarks>
  ///   Use this to position the separator relative to another custom control.
  /// </remarks>
  public string? InsertAfterQualifiedId { get; set; }

  /// <summary>
  ///   Gets or sets the qualified identifier before which this separator should be inserted.
  /// </summary>
  /// <remarks>
  ///   Use this to position the separator relative to another custom control.
  /// </remarks>
  public string? InsertBeforeQualifiedId { get; set; }
}