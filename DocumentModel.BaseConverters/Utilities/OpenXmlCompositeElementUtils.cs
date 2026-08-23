namespace DocumentModel.OpenXml;

/// <summary>
/// This static class contains extension operations to be performed on a OpenXmlCompositeElement object.
/// </summary>
public static class OpenXmlCompositeElementUtils
{
  #region Twips get/set methods

  /// <summary>
  /// Retrieves the Twips value from the specified OpenXmlCompositeElement if an element of the given type is present
  /// and contains a valid Twips value.
  /// </summary>
  /// <typeparam name="ElementType">The type of OpenXmlLeafElement to search for within the composite element.</typeparam>
  /// <param name="openXmlElement">The OpenXmlCompositeElement from which to extract the Twips value. This parameter can be null.</param>
  /// <returns>A Twips object representing the extracted value if a valid Twips value is found; otherwise, null.</returns>
  /// <exception cref="InvalidDataException">Thrown if the found element is not of a supported type for Twips conversion.</exception>
  public static Twips? GetTwipsVal<ElementType>(this DX.OpenXmlCompositeElement? openXmlElement) where ElementType : DX.OpenXmlLeafElement
  {
    if (openXmlElement != null)
    {
      var _element = openXmlElement.Elements<ElementType>().FirstOrDefault();
      if (_element != null)
      {
        if (_element is DXW.TwipsMeasureType twipsMeasure)
        {
          var str = twipsMeasure.Val?.Value;
          if (str != null)
            return new Twips(str);
        }
        else
          if (_element is DXW.NonNegativeShortType nonNegativeShort)
          {
            var n = nonNegativeShort.Val?.Value;
            if (n != null)
              return new Twips((short)n);
          }
          else
            if (_element is DXM.TwipsMeasureType twipsMeasureM)
            {
              var val = twipsMeasureM.Val?.Value;
              if (val != null)
                return new Twips((uint)val);
            }
            else
              throw new InvalidDataException($"Unsupported twips conversion from type {_element.GetType()}");
      }
    }
    return null;
  }

  /// <summary>
  /// Sets the specified twips measurement value on a child element of the given OpenXmlCompositeElement, creating the
  /// child element if it does not already exist. Removes the child element if the value is null.
  /// </summary>
  /// <remarks>This method is typically used to set or clear measurement values, such as margins or spacing, in
  /// Open XML WordprocessingML or MathML documents. The method determines the appropriate value assignment based on the
  /// type of the child element. If the child element does not exist and a non-null value is provided, it is created and
  /// appended to the composite element.</remarks>
  /// <typeparam name="ElementType">The type of OpenXmlLeafElement to create or modify. Must be a type that supports assignment of a twips value.</typeparam>
  /// <param name="openXmlElement">The OpenXmlCompositeElement to which the twips value will be applied. This element must be capable of containing
  /// the specified leaf element type.</param>
  /// <param name="value">The twips value to set. If null, the existing child element of the specified type will be removed.</param>
  /// <exception cref="InvalidDataException">Thrown if the specified ElementType does not support conversion from the twips value.</exception>
  public static void SetTwipsVal<ElementType>(this DX.OpenXmlCompositeElement openXmlElement, Twips? value) where ElementType : DX.OpenXmlLeafElement, new()
  {
    if (value is not null)
    {
      var _element = openXmlElement.Elements<ElementType>().FirstOrDefault();
      if (_element == null)
      {
        _element = new ElementType();
        openXmlElement.AppendChild(_element);
      }
      if (_element is DXW.TwipsMeasureType twipsMeasure)
        twipsMeasure.Val = (string)value;
      else
        if (_element is DXW.NonNegativeShortType nonNegativeShort)
          nonNegativeShort.Val = (short)value;
        else
          if (_element is DXM.TwipsMeasureType twipsMeasureM)
            twipsMeasureM.Val = new DX.UInt32Value((uint)value);
          else
            throw new InvalidDataException($"Unsupported twips conversion to type {_element.GetType()}");
    }
    else
    {
      var _element = openXmlElement.Elements<ElementType>().FirstOrDefault();
      if (_element != null)
        _element.Remove();
    }
  }

  #endregion

  #region Object access methods

  /// <summary>
  /// Retrieves an instance of the specified object type that is constructed from the first child element of the given
  /// OpenXmlCompositeElement, if such a child exists.
  /// </summary>
  /// <remarks>ObjectType must define a public constructor that takes a single OpenXmlElement parameter. If
  /// openXmlElement does not contain a child of type ElementType, or if openXmlElement is null, the method returns
  /// null.</remarks>
  /// <typeparam name="ObjectType">The type of the object to create. Must be a reference type with a constructor that accepts an OpenXmlElement as a
  /// parameter.</typeparam>
  /// <typeparam name="ElementType">The type of OpenXmlElement to search for as a child of the provided OpenXmlCompositeElement.</typeparam>
  /// <param name="openXmlElement">The OpenXmlCompositeElement from which to retrieve the child element. Can be null.</param>
  /// <returns>An instance of ObjectType created from the first child element of type ElementType, or null if no such child
  /// exists or if openXmlElement is null.</returns>
  public static ObjectType? GetObject<ObjectType, ElementType>(this DX.OpenXmlCompositeElement? openXmlElement) where ObjectType : class
    where ElementType : DX.OpenXmlElement
  {
    if (openXmlElement != null)
    {
      var _element = openXmlElement.Elements<ElementType>().FirstOrDefault();
      if (_element != null)
      {
        var constructor = typeof(ObjectType).GetConstructor(new Type[] { typeof(DX.OpenXmlElement) });
        Debug.Assert(constructor != null, $"Type {typeof(ObjectType)} must have constructor with OpenXmlElement parameter");
        return (ObjectType)constructor!.Invoke([_element]);
      }
    }
    return null;
  }

  #endregion

  #region Child elements access methods

  /// <summary>
  /// Adds the specified child element to the given OpenXmlCompositeElement, ensuring that the child is detached from
  /// any existing parent before being appended.
  /// </summary>
  /// <remarks>If the child element is already part of another parent, it will be removed from that parent
  /// before being added to the specified composite element. This method modifies the document structure by reparenting
  /// the child element as needed.</remarks>
  /// <param name="openXmlElement">The OpenXmlCompositeElement to which the child element will be added. Cannot be null.</param>
  /// <param name="childElement">The OpenXmlElement to add as a child. If this element already has a parent, it will be removed from that parent
  /// before being appended. Cannot be null.</param>
  public static void AddChildElement(this DX.OpenXmlCompositeElement openXmlElement, DX.OpenXmlElement childElement)
  {
    if (childElement.Parent != null)
      childElement.Remove();
    openXmlElement.AppendChild(childElement);
  }

  /// <summary>
  /// Retrieves the child elements of the specified type from the given OpenXmlCompositeElement.
  /// </summary>
  /// <remarks>Use this method to query for specific types of child elements within an OpenXmlCompositeElement.
  /// This enables type-safe access to elements and simplifies element filtering in Open XML document
  /// processing.</remarks>
  /// <param name="openXmlElement">The OpenXmlCompositeElement instance from which to retrieve child elements. Cannot be null.</param>
  /// <param name="childElementType">The Type used to filter child elements. Only elements matching this type will be included in the result. Cannot be
  /// null.</param>
  /// <returns>An IEnumerable of DX.OpenXmlElement containing the child elements that match the specified type. The collection
  /// will be empty if no matching elements are found.</returns>
  public static IEnumerable<DX.OpenXmlElement> ElementsOfType(this DX.OpenXmlCompositeElement openXmlElement, Type childElementType)
  {
    return openXmlElement.Elements().Where(e => e.MatchType(childElementType));
  }

  /// <summary>
  /// Retrieves the first child element of the specified type from the given composite OpenXml element.
  /// </summary>
  /// <remarks>This method searches the immediate children of the provided composite element and returns the
  /// first element that matches the specified type. If the element has no children or none match the specified type,
  /// null is returned.</remarks>
  /// <param name="openXmlElement">The composite OpenXml element from which to retrieve the child element. Cannot be null.</param>
  /// <param name="childElementType">The type of the child element to retrieve. Must be a valid OpenXml element type.</param>
  /// <returns>The first child element of the specified type, or null if no such child element exists.</returns>
  public static DX.OpenXmlElement? ElementOfType(this DX.OpenXmlCompositeElement openXmlElement, Type childElementType)
  {
    return openXmlElement.Elements().FirstOrDefault(e => e.MatchType(childElementType));
  }

  /// <summary>
  /// Determines whether the specified OpenXmlElement is an instance of the given type or represents an unknown element.
  /// </summary>
  /// <param name="element">The OpenXmlElement to evaluate against the specified type.</param>
  /// <param name="type">The Type to check for compatibility with the element.</param>
  /// <returns>true if the element is an instance of the specified type or is an unknown element; otherwise, false.</returns>
  private static bool MatchType(this DX.OpenXmlElement element, Type type)
  {
    if (type.IsInstanceOfType(element))
      return true;

    DX.OpenXmlElement? prototype = null;
    try
    {
      prototype = Activator.CreateInstance(type) as DX.OpenXmlElement;
    }
    catch
    {
      return false;
    }

    if (prototype == null)
      return false;

    return element.LocalName == prototype.LocalName && element.NamespaceUri == prototype.NamespaceUri;
  }

  #endregion
}

