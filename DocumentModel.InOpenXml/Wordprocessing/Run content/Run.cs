using System.Text;

using DocumentModel.Math;

using Qhta.OpenXmlTools;

namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines a region of text with a common set of properties. 
///   A run allows the producer to specify a single set of formatting properties, 
///   applying the same information to all the contents of the run. .
/// </summary>
[OpenXmlType(typeof(DXW.Run))]
[DataContract]
[XmlRoot("Run", Namespace = "DocumentModel.Wordprocessing")]
[DirectAccess(true)]
[ContentProperty(nameof(Items))]
public partial class Run: ModelElement<DXW.Run>, ITextualElement, IParagraphContent, ISdtRunContent, IRubyContent,
  IBidirectionalContent, IMathArgumentContent
{
  /// <summary>
  /// Initializes a new instance of the Run class.
  /// </summary>
  public Run(): base() { }

  /// <summary>
  /// Initializes a new instance of the Run class with the specified parent object.
  /// </summary>
  /// <param name = "parent">The parent object that will contain this Run instance. This parameter establishes the hierarchical relationship
  /// within the object model and cannot be null.</param>
  /// <param name = "openXmlElement">The OpenXmlCompositeElement that provides the XML data for the Run instance. Cannot be null.</param>
  public Run(ModelElement parent, DX.OpenXmlCompositeElement? openXmlElement): base(parent, openXmlElement) { }

  /// <summary>
  /// Initializes a new instance of the Run class using the specified OpenXmlCompositeElement.  
  /// </summary>
  /// <param name="openXmlElement">The OpenXmlCompositeElement that provides the underlying XML data for the run.</param>
  public Run(DX.OpenXmlCompositeElement openXmlElement): base(openXmlElement) { }

  /// <summary>
  ///   Revision Identifier for Run Properties
  /// </summary>
  [OpenXmlProperty(nameof(DXW.Run.RsidRunProperties))]
  public HexInt? RsidProps
  {
    get => _RsidProps ??= GetProperty<HexInt?>(GetUpdatableElement()?.RsidRunProperties);
    set => UpdateField(ref _RsidProps, value, nameof(RsidProps));
  }

  private HexInt? _RsidProps;

  /// <summary>
  ///   Revision Identifier for Run Deletion
  /// </summary>
  [OpenXmlProperty(nameof(DXW.Run.RsidRunDeletion))]
  public HexInt? RsidDel
  {
    get => _RsidDel ??= GetProperty<HexInt?>(GetUpdatableElement()?.RsidRunDeletion);
    set => UpdateField(ref _RsidDel, value, nameof(RsidDel));
  }

  private HexInt? _RsidDel;

  /// <summary>
  ///   Revision Identifier for Run
  /// </summary>
  [OpenXmlProperty(nameof(DXW.Run.RsidRunAddition))]
  public HexInt? RsidAdd
  {
    get => _RsidAdd ??= GetProperty<HexInt?>(GetUpdatableElement()?.RsidRunAddition);
    set => UpdateField(ref _RsidAdd, value, nameof(RsidAdd));
  }

  private HexInt? _RsidAdd;

  /// <summary>
  ///   Specifies a set of run properties which shall be applied to the contents of the parent run 
  ///   after all style formatting has been applied to the text. These properties are defined as direct formatting, 
  ///   since they are directly applied to the run and supersede any formatting from styles..
  /// </summary>
  [OpenXmlProperty(nameof(DXW.Run.RunProperties))]
  public RunProperties? RunProperties
  {
    get => _RunProperties ??= GetProperty<RunProperties?>(GetUpdatableElement()?.RunProperties);
    set => UpdateField(ref _RunProperties, value, nameof(RunProperties));
  }

  private RunProperties? _RunProperties;

  /// <summary>
  /// Collection of Run items, which can include text, breaks, fields, and other inline elements. 
  /// </summary>
  [XmlArray("Items")]
  [XmlArrayItem("Break", typeof(DMW.Break))]
  [XmlArrayItem("Drawing", typeof(DMW.Drawing))]
  [XmlArrayItem("NoBreakHyphen", typeof(DMW.NoBreakHyphen))]
  [XmlArrayItem("SoftHyphen", typeof(DMW.SoftHyphen))]
  [XmlArrayItem("DayShort", typeof(DMW.DayShort))]
  [XmlArrayItem("MonthShort", typeof(DMW.MonthShort))]
  [XmlArrayItem("YearShort", typeof(DMW.YearShort))]
  [XmlArrayItem("DayLong", typeof(DMW.DayLong))]
  [XmlArrayItem("MonthLong", typeof(DMW.MonthLong))]
  [XmlArrayItem("YearLong", typeof(DMW.YearLong))]
  [XmlArrayItem("AnnotationReferenceMark", typeof(DMW.AnnotationReferenceMark))]
  [XmlArrayItem("FootnoteReferenceMark", typeof(DMW.FootnoteReferenceMark))]
  [XmlArrayItem("EndnoteReferenceMark", typeof(DMW.EndnoteReferenceMark))]
  [XmlArrayItem("SeparatorMark", typeof(DMW.SeparatorMark))]
  [XmlArrayItem("ContinuationSeparatorMark", typeof(DMW.ContinuationSeparatorMark))]
  [XmlArrayItem("PageNumber", typeof(DMW.PageNumber))]
  [XmlArrayItem("CarriageReturn", typeof(DMW.CarriageReturn))]
  [XmlArrayItem("TabChar", typeof(DMW.TabChar))]
  [XmlArrayItem("LastRenderedPageBreak", typeof(DMW.LastRenderedPageBreak))]
  [XmlArrayItem("FieldChar", typeof(DMW.FieldChar))]
  [XmlArrayItem("FootnoteReference", typeof(DMW.FootnoteReference))]
  [XmlArrayItem("EndnoteReference", typeof(DMW.EndnoteReference))]
  [XmlArrayItem("CommentReference", typeof(DMW.CommentReference))]
  [XmlArrayItem("EmbeddedObject", typeof(DMW.EmbeddedObject))]
  [XmlArrayItem("Picture", typeof(DMW.Picture))]
  [XmlArrayItem("PositionalTab", typeof(DMW.PositionalTab))]
  [XmlArrayItem("RunProperties", typeof(DMW.RunProperties))]
  [XmlArrayItem("Ruby", typeof(DMW.Ruby))]
  [XmlArrayItem("SymbolChar", typeof(DMW.SymbolChar))]
  [XmlArrayItem("Text", typeof(DMW.RunText))]
  [XmlArrayItem("DeletedText", typeof(DMW.DeletedText))]
  [XmlArrayItem("FieldCode", typeof(DMW.FieldCode))]
  [XmlArrayItem("DeletedFieldCode", typeof(DMW.DeletedFieldCode))]
  public RunItemsCollection Items => _Items ??= new RunItemsCollection(this, GetUpdatableElement());

  private RunItemsCollection? _Items;

  /// <summary>
  ///  Checks if the specified OpenXmlElement item is acceptable.
  ///  RunProperties are not accepted as items in the Run's Items collection, as they are handled separately through the RunProperties property.
  /// </summary>
  /// <param name="item"></param>
  /// <returns></returns>
  private bool AcceptSourceItem(DX.OpenXmlElement item)
  {
    return item is not DXW.RunProperties;
  }

  /// <summary>
  /// Gets the source OpenXml elements that are considered acceptable items for the Run's Items collection.
  /// This property filters the elements of the underlying OpenXml Run element,
  /// excluding any elements that are not accepted by the AcceptSourceItem method.
  /// </summary>
  private IEnumerable<DX.OpenXmlElement> SourceElements =>
    GetUpdatableElement()!.Elements().Where(AcceptSourceItem);

  /// <summary>
  /// Mapping of specific OpenXml element types to their corresponding character representations.
  /// This dictionary is used to translate certain OpenXml elements, such as TabChar, CarriageReturn, NoBreakHyphen, and SoftHyphen,
  /// into their respective character values for text processing and representation.
  /// </summary>
  private static readonly BiDiDictionary<Type, char> _SymbolCharTypesMap = new BiDiDictionary<Type, char>()
  {
    { typeof(DXW.TabChar), '\t' },
    { typeof(DXW.CarriageReturn), '\r' },
    { typeof(DXW.NoBreakHyphen), '\u2011' },
    { typeof(DXW.SoftHyphen), '\u00AD' }
  };

  /// <summary>
  /// The text value represented by this element.
  /// </summary>
  [XmlIgnore]
  public string? Text { get => GetText(); set => SetText(value); }

  /// <summary>
  /// Gets the concatenated text content of the run, combining all text elements within the run's items collection.
  /// </summary>
  /// <returns>The concatenated text content of the run.</returns>
  public string GetText()
  {
    var sb = new StringBuilder();
    foreach (var item in SourceElements)
    {
      sb.Append(GetReplacementText(item));
    }
    return sb.ToString();
  }

  /// <summary>
  /// Gets the replacement text for a given OpenXmlElement item. If the item is a textual element, it returns its text content.
  /// For certain special elements, it returns their corresponding character representations.
  /// For other elements, it returns the Unicode object replacement character '\xFFFC'.
  /// </summary>
  /// <param name="item">The OpenXmlElement item for which to get the replacement text.</param>
  /// <returns>The replacement text for the given item.</returns>
  private string GetReplacementText(DX.OpenXmlElement item)
  {
    if (item is DXW.TextType textualElement)
    {
      return textualElement.Text;
    }
    else if (_SymbolCharTypesMap.TryGetValue(item.GetType(), out var c))
    {
      return c.ToString();
    }
    else if (item is DXW.SymbolChar symbolChar)
    {
      var uniChar = new SymbolChar(symbolChar).GetUnicodeChar();
      if (uniChar != null)
        return uniChar!.ToString()!;
      else
        return "\xFFFC";
    }
    else
    {
      return "\xFFFC";
    }
  }

  /// <summary>
  /// Groups the items in the run into contiguous segments of either textual elements or non-textual elements.
  /// </summary>
  private class ElementsGroup: List<DX.OpenXmlElement>
  {
    public bool IsObject { get; init; }
  }

  /// <summary>
  /// Represents a list of ElementsGroup objects along with the count of object groups.
  /// </summary>
  private class ElementsGroups: List<ElementsGroup>
  {
    public int ObjectGroupsCount { get; set; }
  }

  /// <summary>
  /// Groups the characters in a string into contiguous segments of either normal characters or special object characters (represented by '\xFFFC').
  /// </summary>
  private class CharGroup: List<char>
  {
    public bool IsObject { get; init; }
  }

  /// <summary>
  /// Represents a list of character groups (strings) along with the count of object groups.
  /// </summary>
  private class CharsGroups: List<CharGroup>
  {
    public int ObjectGroupsCount { get; set; }
  }

  /// <summary>
  /// Sets the text content of the run. Setting the text will update the underlying OpenXml elements to reflect the new text,
  /// while preserving the structure of non-textual elements (such as drawings) in the run.
  /// If the number of object groups in the existing run elements does not match the number of object groups in the new text,
  /// an InvalidOperationException will be thrown.
  /// </summary>
  /// <param name="value">The text content to set</param>
  public void SetText(string? value)
  {
    if (GetUpdatableElement() is null)
      throw new ApplicationException("The run element can't set textas it has no updatable element.");

    value ??= string.Empty;
    var sourceElements = SourceElements.ToList();
    var elementsGroups = GroupElements(sourceElements);
    var charsGroups = GroupChars(value);
    if (elementsGroups.ObjectGroupsCount != charsGroups.ObjectGroupsCount)
    {
      throw new InvalidOperationException(
        "The number of object groups in the existing run elements does not match the number of object groups in the new text.");
    }
    int elementGroupIndex = 0;
    int charGroupIndex = 0;
    while (elementGroupIndex < elementsGroups.Count && charGroupIndex < charsGroups.Count)
    {
      var elementGroup = elementsGroups[elementGroupIndex];
      var charGroup = charsGroups[charGroupIndex];
      if (elementGroup.IsObject != charGroup.IsObject)
      {
        if (elementGroup.IsObject && !charGroup.IsObject)
        {
          InsertCharGroupBefore(charGroup, elementGroup.First());
          charGroupIndex++;
        }
        else if (!elementGroup.IsObject && charGroup.IsObject)
        {
          RemoveElementGroup(elementGroup);
          elementGroupIndex++;
        }
      }

      // Update the text of the element group with the characters from the char group
      if (!elementGroup.IsObject)
      {
        ReplaceElementGroup(elementGroup, charGroup);
        elementGroupIndex++;
        charGroupIndex++;
      }
      else
      {
        elementGroupIndex++;
        charGroupIndex++;
      }
    }
    while (elementGroupIndex < elementsGroups.Count)
    {
      RemoveElementGroup(elementsGroups[elementGroupIndex]);
      elementGroupIndex++;
    }
    while (charGroupIndex < charsGroups.Count)
    {
      InsertCharGroupBefore(charsGroups[charGroupIndex], null);
      charGroupIndex++;
    }

    // Clear the cached items collection to ensure it reflects the updated state
    _Items = null;
  }

  /// <summary>
  /// Groups the provided items into contiguous segments of either textual and symbol elements or non-textual elements.
  /// </summary>
  /// <param name="items">The items to group.</param>
  /// <returns>A list of grouped items.</returns>
  private ElementsGroups GroupElements(IEnumerable<DX.OpenXmlElement> items)
  {
    var groups = new ElementsGroups();
    ElementsGroup? currentGroup = null;
    foreach (var item in items)
    {
      if (GetReplacementText(item) != "\xFFFC")
      {
        if (currentGroup == null || currentGroup.IsObject)
        {
          currentGroup = new ElementsGroup { IsObject = false };
          groups.Add(currentGroup);
        }
        currentGroup.Add(item);
      }
      else
      {
        if (currentGroup == null || !currentGroup.IsObject)
        {
          groups.ObjectGroupsCount++;
          currentGroup = new ElementsGroup { IsObject = true };
          groups.Add(currentGroup);
        }
        currentGroup.Add(item);
      }
    }
    return groups;
  }

  /// <summary>
  /// Groups the provided items into contiguous segments of normal characters and special object characters (represented by '\xFFFC').
  /// </summary>
  /// <param name="chars">The characters to group.</param>
  /// <returns>A list of grouped characters.</returns>
  private CharsGroups GroupChars(IEnumerable<char> chars)
  {
    var groups = new CharsGroups();
    CharGroup? currentGroup = null;
    foreach (var c in chars)
    {
      var isObjectChar = c == '\xFFFC';
      if (currentGroup == null || currentGroup.IsObject != isObjectChar)
      {
        if (isObjectChar)
        {
          groups.ObjectGroupsCount++;
        }
        currentGroup = new CharGroup { IsObject = isObjectChar };
        groups.Add(currentGroup);
      }
      currentGroup.Add(c);
    }
    return groups;
  }

  /// <summary>
  /// Removes all elements in the specified ElementsGroup from the underlying OpenXml structure.
  /// </summary>
  /// <param name="elementGroup">The group of elements to remove.</param>
  private void RemoveElementGroup(ElementsGroup elementGroup)
  {
    foreach (var element in elementGroup)
    {
      element.Remove();
    }
  }

  /// <summary>
  /// Inserts a new CharGroup before the specified reference element in the underlying OpenXml structure.
  /// </summary>
  /// <param name="charGroup">The group of characters to insert.</param>
  /// <param name="referenceElement">The reference element before which the charGroup will be inserted. If null, the charGroup will be appended at the end.</param>
  private void InsertCharGroupBefore(CharGroup charGroup, DX.OpenXmlElement? referenceElement)
  {
    var textElement = CreateTextElements(charGroup);
    if (referenceElement != null)
    {
      foreach (var element in textElement)
      {
        referenceElement.InsertBeforeSelf(element);
      }
    }
    else
    {
      var updatableElement = GetUpdatableElement()!;
      foreach (var element in textElement)
      {
        // Assuming there's a method to append elements at the end of the parent
        updatableElement.AppendChild(element);
      }
    }
  }

  /// <summary>
  /// Replaces the text of the specified ElementsGroup with the characters from the provided CharGroup.
  /// </summary>
  /// <param name="elementGroup">The group of elements to be replaced.</param>
  /// <param name="charGroup">The group of characters to replace the elements with.</param>
  private void ReplaceElementGroup(ElementsGroup elementGroup, CharGroup charGroup)
  {
    var textElement = CreateTextElements(charGroup);
    InsertCharGroupBefore(charGroup, elementGroup.FirstOrDefault());
    RemoveElementGroup(elementGroup);
  }

  /// <summary>
  /// Creates a list of OpenXml elements based on the provided CharGroup.
  /// If the CharGroup contains normal characters, they are combined into a single Text element.
  /// Special object characters are converted into their corresponding OpenXml elements.
  /// </summary>
  /// <param name="charGroup">The group of characters to convert into OpenXml elements.</param>
  /// <returns>A list of OpenXml elements representing the characters in the charGroup.</returns>
  private List<DX.OpenXmlElement> CreateTextElements(CharGroup charGroup)
  {
    var elements = new List<DX.OpenXmlElement>();
    var sb = new StringBuilder();
    string s;
    foreach (var c in charGroup)
    {
      if (_SymbolCharTypesMap.TryGetValue1(c, out var symbolType))
      {
        s = sb.ToString();
        if (!string.IsNullOrEmpty(s))
        {
          elements.Add(new DXW.Text(s));
        }
        sb.Clear();
        var newSymbol = (DX.OpenXmlElement)Activator.CreateInstance(symbolType)!;
        elements.Add(newSymbol);
      }
      else
      {
        sb.Append(c);
      }
    }
    s = sb.ToString();
    if (!string.IsNullOrEmpty(s))
    {
      elements.Add(new DXW.Text(s));
    }
    return elements;
  }

  /// <summary>
  /// Adds a new ModelElement to the run's items collection.
  /// </summary>
  /// <param name="element">The ModelElement to add to the run`'s items collection.</param>
  public void Add(ModelElement element)
  {
    Items.AddModelElement(element);
  }
}