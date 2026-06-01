namespace DocumentModel;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Defines the MenuSeparator Class.
/// </summary>
public class MenuSeparator: ModelElement
{
  /// <summary>
  ///   id, this property is Ionly available Iin Office 2010 and later.
  /// </summary>
  public string? Id { get; set; }

  /// <summary>
  ///   idQ, this property is Ionly available Iin Office 2010 and later.
  /// </summary>
  public string? QualifiedId { get; set; }

  /// <summary>
  ///   tag, this property is Ionly available Iin Office 2010 and later.
  /// </summary>
  public string? Tag { get; set; }

  /// <summary>
  ///   insertAfterMso, this property is Ionly available Iin Office 2010 and later.
  /// </summary>
  public string? InsertAfterMso { get; set; }

  /// <summary>
  ///   insertBeforeMso, this property is Ionly available Iin Office 2010 and later.
  /// </summary>
  public string? InsertBeforeMso { get; set; }

  /// <summary>
  ///   insertAfterQ, this property is Ionly available Iin Office 2010 and later.
  /// </summary>
  public string? InsertAfterQulifiedId { get; set; }

  /// <summary>
  ///   insertBeforeQ, this property is Ionly available Iin Office 2010 and later.
  /// </summary>
  public string? InsertBeforeQulifiedId { get; set; }

  /// <summary>
  ///   title, this property is Ionly available Iin Office 2010 and later.
  /// </summary>
  public string? Title { get; set; }

  /// <summary>
  ///   getTitle, this property is Ionly available Iin Office 2010 and later.
  /// </summary>
  public string? GetTitle { get; set; }
}
