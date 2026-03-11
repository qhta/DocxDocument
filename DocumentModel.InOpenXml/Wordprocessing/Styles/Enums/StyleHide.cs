namespace DocumentModel.Wordprocessing;

/// <summary>
/// Specifies the visibility states that can be applied to a style, allowing multiple states to be combined using
/// bitwise operations.
/// </summary>
/// <remarks>Use this enumeration to control how styles are displayed or hidden in a user interface. Multiple
/// values can be combined to represent complex visibility scenarios. For example, a style can be both hidden and
/// semi-hidden by combining the corresponding flags.</remarks>
[Flags]
public enum StyleHide
{
  /// <summary>
  /// This flag specifies whether the style shall be hidden from any and all user interfaces when this document is
  /// loaded by an application. If this element is set, then this style can be used to format content (i.e. any content
  /// which references this style shall have its properties as normal), but the style shall be hidden from all user
  /// interface associated with that application.
  /// </summary>
  /// <note>This setting is typically used to hide styles which are being used internally by an application
  /// which should not be used as formatting in a typical case.
  /// </note>
  Hidden = 1,

  /// <summary>
  /// This flag specifies whether the style shall be hidden from the main user interface when this document is
  /// loaded by an application. If this element is set, then this style can be used to format content (i.e. any content
  /// which references this style shall have its properties as normal), but the style shall be hidden from the main user
  /// interface associated with that application.
  /// </summary>
  /// <note>
  /// This setting is intended to define a style property which allows styles to be seen and modified in an advanced
  /// user interface, without exposing the style in a less advanced setting, for example, the style which is used to
  /// format the contents of a comment should typically not be shown in a simple user interface (as it is uncommon to
  /// want to modify it), but would be inappropriate to hide completely using the hidden element, as very
  /// advanced users might want to change its appearance.
  /// </note>
  SemiHidden = 2,

  /// <summary>
  /// This element specifies whether the semiHidden property shall be removed when this style is used
  /// by the content of the document. If this element is set, then an application shall ensure that even if the
  /// semiHidden element is specified on a style, that this property is removed when the document is resaved if the
  /// style is referenced by any content in the document.
  /// </summary>  
  UnhiddenWhenUsed = 4,
}