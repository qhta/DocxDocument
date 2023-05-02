namespace DocumentModel.UI;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the MenuSeparator Class.
/// </summary>
public class MenuSeparator: ModelElement
{
  /// <summary>
  ///   id
  /// </summary>
  public string? Id { get; set; }

  /// <summary>
  ///   idQ
  /// </summary>
  public string? IdQ { get; set; }

  /// <summary>
  ///   insertAfterMso
  /// </summary>
  public string? InsertAfterMso { get; set; }

  /// <summary>
  ///   insertBeforeMso
  /// </summary>
  public string? InsertBeforeMso { get; set; }

  /// <summary>
  ///   insertAfterQ
  /// </summary>
  public string? InsertAfterQ { get; set; }

  /// <summary>
  ///   insertBeforeQ
  /// </summary>
  public string? InsertBeforeQ { get; set; }

  /// <summary>
  ///   title
  /// </summary>
  public string? Title { get; set; }

  /// <summary>
  ///   getTitle
  /// </summary>
  public string? GetTitle { get; set; }
}