namespace DocumentModel.UI;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the VerticalSeparator Class.
/// </summary>
public class VerticalSeparator: ModelElement
{
  /// <summary>
  ///   id
  /// </summary>
  public String? Id { get; set; }

  /// <summary>
  ///   idQ
  /// </summary>
  public String? IdQ { get; set; }

  /// <summary>
  ///   visible
  /// </summary>
  public Boolean? Visible { get; set; }

  /// <summary>
  ///   getVisible
  /// </summary>
  public String? GetVisible { get; set; }

  /// <summary>
  ///   insertAfterMso
  /// </summary>
  public String? InsertAfterMso { get; set; }

  /// <summary>
  ///   insertBeforeMso
  /// </summary>
  public String? InsertBeforeMso { get; set; }

  /// <summary>
  ///   insertAfterQ
  /// </summary>
  public String? InsertAfterQ { get; set; }

  /// <summary>
  ///   insertBeforeQ
  /// </summary>
  public String? InsertBeforeQ { get; set; }
}