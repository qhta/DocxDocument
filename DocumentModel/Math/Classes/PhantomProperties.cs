namespace DocumentModel.Math;

/// <summary>
///   This element specifies properties of the Phantom object, 
///   including whether the phantom is hidden or visible 
///   and the amount of space that is considered when laying out text and objects around phantoms.
/// </summary>
public class PhantomProperties: ModelElement
{
  /// <summary>
  ///   Specifies the show property of the phantom phant. When 0 or false, the phant base e is hidden. 
  ///   If this element is omitted, the base e is shown. 
  ///   Whether the element is absent or present without the val attribute, 
  ///   the default of the val attribute is 1 meaning that this property is applied.
  /// </summary>
  public bool? ShowPhantom { get; set; }

  /// <summary>
  ///   This element specifies that the phantom has zero width. 
  ///   The width of the contents of the phantom is not considered during layout. 
  ///   When this property is omitted, the phantom does have width (zero width is not applied).
  ///   When the element is absent, the default value of the property is 0 meaning that this property is not applied.
  ///   When the element is present and the val attribute is absent, 
  ///   the default of the val attribute is 1 meaning that this property is applied.
  /// </summary>
  public bool? ZeroWidth { get; set; }

  /// <summary>
  ///   This element specifies that the phantom has zero ascent. 
  ///   The ascent of the contents of the phantom is not considered during layout. 
  ///   When this property is omitted, the phantom does have ascent (zero ascent is not applied).
  ///   When the element is absent, the default value of the property is 0 meaning that this property is not applied.
  ///   When the element is present and the val attribute is absent, 
  ///   the default of the val attribute is 1 meaning that this property is applied.
  /// </summary>
  public bool? ZeroAscent { get; set; }

  /// <summary>
  ///   This element specifies that the phantom has zero descent. 
  ///   The descent of the contents of the phantom is not considered during layout. 
  ///   When this property is omitted, the phantom does have descent (zero descent is not applied).
  ///   When the element is absent, the default value of the property is 0 meaning that this property is not applied.
  ///   When the element is present and the val attribute is absent, 
  ///   the default of the val attribute is 1 meaning that this property is applied.
  /// </summary>
  public bool? ZeroDescent { get; set; }

  /// <summary>
  ///   This element specifies that the phantom is transparent for spacing. 
  ///   This means that if the contents of the phantom are belonging to a special spacing class 
  ///   (such as binary operators, relational operators, differentials, etc.), 
  ///   the contents of that phantom are taken into consideration when laying out text. 
  ///   If transparency is turned off, then the contents of the phantom are ignored during layout. 
  ///   When this element is omitted, transparency is 0 or false. In other words, when the element is absent, 
  ///   the default value of the property is 0 meaning that this property is not applied.
  ///   When the element is present and the val attribute is absent, 
  ///   the default of the val attribute is 1 meaning that this property is applied.
  /// </summary>
  public bool? Transparent { get; set; }

  /// <summary>
  ///   Specifies formatting of phantom object argument.
  /// </summary>
  public ControlProperties? ControlProperties { get; set; }
}