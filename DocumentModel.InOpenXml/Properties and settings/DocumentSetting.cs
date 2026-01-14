namespace DocumentModel;
/// <summary>
///   Document setting property. Its type is taken from OpenXml element containing the OpenXml wordprocessing settings.
/// </summary>

///   <item><description><see cref="T:DocumentFormat.OpenXml.CustomXmlSchemaReferences.SchemaLibrary" /> <c>&lt;sl:schemaLibrary&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Math.MathProperties" /> <c>&lt;m:mathPr&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Office2010.Word.ConflictMode" /> <c>&lt;w14:conflictMode&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Office2010.Word.DefaultImageDpi" /> <c>&lt;w14:defaultImageDpi&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Office2010.Word.DiscardImageEditingData" /> <c>&lt;w14:discardImageEditingData&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Office2010.Word.DocumentId" /> <c>&lt;w14:docId&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Office2013.Word.ChartTrackingRefBased" /> <c>&lt;w15:chartTrackingRefBased&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Office2013.Word.PersistentDocumentId" /> <c>&lt;w15:docId&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Wordprocessing.ActiveWritingStyle" /> <c>&lt;w:activeWritingStyle&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Wordprocessing.AttachedSchema" /> <c>&lt;w:attachedSchema&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Wordprocessing.AttachedTemplate" /> <c>&lt;w:attachedTemplate&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Wordprocessing.Captions" /> <c>&lt;w:captions&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Wordprocessing.CharacterSpacingControl" /> <c>&lt;w:characterSpacingControl&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Wordprocessing.ClickAndTypeStyle" /> <c>&lt;w:clickAndTypeStyle&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Wordprocessing.ColorSchemeMapping" /> <c>&lt;w:clrSchemeMapping&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Wordprocessing.Compatibility" /> <c>&lt;w:compat&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Wordprocessing.ConsecutiveHyphenLimit" /> <c>&lt;w:consecutiveHyphenLimit&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Wordprocessing.DecimalSymbol" /> <c>&lt;w:decimalSymbol&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Wordprocessing.DefaultTableStyle" /> <c>&lt;w:defaultTableStyle&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Wordprocessing.DisplayHorizontalDrawingGrid" /> <c>&lt;w:displayHorizontalDrawingGridEvery&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Wordprocessing.DisplayVerticalDrawingGrid" /> <c>&lt;w:displayVerticalDrawingGridEvery&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Wordprocessing.DocumentProtection" /> <c>&lt;w:documentProtection&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Wordprocessing.DocumentType" /> <c>&lt;w:documentType&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Wordprocessing.DocumentVariables" /> <c>&lt;w:docVars&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Wordprocessing.DrawingGridHorizontalOrigin" /> <c>&lt;w:drawingGridHorizontalOrigin&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Wordprocessing.DrawingGridHorizontalSpacing" /> <c>&lt;w:drawingGridHorizontalSpacing&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Wordprocessing.DrawingGridVerticalOrigin" /> <c>&lt;w:drawingGridVerticalOrigin&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Wordprocessing.DrawingGridVerticalSpacing" /> <c>&lt;w:drawingGridVerticalSpacing&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Wordprocessing.EndnoteDocumentWideProperties" /> <c>&lt;w:endnotePr&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Wordprocessing.FootnoteDocumentWideProperties" /> <c>&lt;w:footnotePr&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Wordprocessing.HeaderShapeDefaults" /> <c>&lt;w:hdrShapeDefaults&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Wordprocessing.HyphenationZone" /> <c>&lt;w:hyphenationZone&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Wordprocessing.MailMerge" /> <c>&lt;w:mailMerge&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Wordprocessing.NoLineBreaksAfterKinsoku" /> <c>&lt;w:noLineBreaksAfter&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Wordprocessing.NoLineBreaksBeforeKinsoku" /> <c>&lt;w:noLineBreaksBefore&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Wordprocessing.ProofState" /> <c>&lt;w:proofState&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Wordprocessing.ReadModeInkLockDown" /> <c>&lt;w:readModeInkLockDown&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Wordprocessing.RevisionView" /> <c>&lt;w:revisionView&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Wordprocessing.Rsids" /> <c>&lt;w:rsids&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Wordprocessing.ShapeDefaults" /> <c>&lt;w:shapeDefaults&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Wordprocessing.StyleLockStylesPart" /> <c>&lt;w:styleLockQFSet&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Wordprocessing.StyleLockThemesPart" /> <c>&lt;w:styleLockTheme&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Wordprocessing.StylePaneFormatFilter" /> <c>&lt;w:stylePaneFormatFilter&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Wordprocessing.StylePaneSortMethods" /> <c>&lt;w:stylePaneSortMethod&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Wordprocessing.SummaryLength" /> <c>&lt;w:summaryLength&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Wordprocessing.ThemeFontLanguages" /> <c>&lt;w:themeFontLang&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Wordprocessing.UICompatibleWith97To2003" /> <c>&lt;w:uiCompat97To2003&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Wordprocessing.View" /> <c>&lt;w:view&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Wordprocessing.WriteProtection" /> <c>&lt;w:writeProtection&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Wordprocessing.Zoom" /> <c>&lt;w:zoom&gt;</c></description></item>

public class DocumentSetting : DocumentProperty
{

  /// <summary>
  /// The underlying Open XML setting associated with this instance.
  /// </summary>
  internal DX.OpenXmlElement? OpenXmlSetting { get; private set; }

  /// <summary>
  /// Type of Open XML setting, if available.
  /// </summary>
  internal Type? OpenXmlSettingType { get; private set; }

  /// <summary>
  /// Default constructor needed for serialization.
  /// </summary>
  public DocumentSetting() : base()
  {
  }

  /// <summary>
  /// Initializes a new instance of the <see cref="CustomDocumentPropertyClass"/> class.
  /// </summary>
  /// <param name="propertiesCollection">Collection that contains this property</param>
  /// <param name="openXmlDocumentSetting">Element from the Open XML SDK representing a document setting.</param>
  public DocumentSetting(DocumentSettings propertiesCollection,
    DX.OpenXmlElement openXmlDocumentSetting) //: base(propertiesCollection)
  {
    OpenXmlSetting = openXmlDocumentSetting;
    OpenXmlSettingType = openXmlDocumentSetting.GetType();
  }

  /// <summary>
  /// Creates and initializes an open custom document property based on the current state of the object.
  /// </summary>
  /// <remarks>If the custom document property has already been created, this method returns the existing
  /// instance. Otherwise, it creates a new property and initializes it with the current values.</remarks>
  /// <returns>A <see cref="CP.CustomDocumentProperty"/> instance representing the open custom document property with values set
  /// from the current object.</returns>
  public DX.OpenXmlElement? CreateOpenCustomDocumentProperty()
  {
    Debug.Assert(OpenXmlSettingType is not null,
      "OpenXmlSettingType must be set before calling CreateOpenCustomDocumentProperty.");
    if (OpenXmlSettingType.IsSubclassOf(typeof(DXWP.EmptyType)))
    {
      if (Value == null)
        return null;
      if (Value?.ToBoolean() == false)
        return null;
      if (Value?.ToBoolean() == true)
        return (DX.OpenXmlElement)Activator.CreateInstance(OpenXmlSettingType!)!;
      throw new InvalidOperationException($"Value of {Value} can't be converted to OpenXmlSettingType");
    }
    OpenXmlSetting ??= (DX.OpenXmlElement)Activator.CreateInstance(OpenXmlSettingType!)!;
    SetValueToOpenXmlProperty(OpenXmlSetting);
    return OpenXmlSetting;
  }

  /// <summary>
  /// Gets values from OpenXml CustomDocumentProperty to this instance.
  /// </summary>
  private void GetValuesFromOpenXmlProperty(DX.OpenXmlElement openXmlCustomDocumentProperty)
  {
    foreach (var propertyInfo in typeof(CustomProperty).GetProperties())
    {
      var value = propertyInfo.GetValue(openXmlCustomDocumentProperty);
      propertyInfo.SetValue(this, value);
    }
  }

  /// <summary>
  /// Sets the value of this setting to the corresponding properties of the specified
  /// of the specified OpenXml element.
  /// </summary>
  private void SetValueToOpenXmlProperty(DX.OpenXmlElement openXmlSettingElement)
  {
    if (openXmlSettingElement is DX.OpenXmlLeafElement leafElement)
      SetValueToOpenXmlProperty(leafElement);
    else if (openXmlSettingElement is DX.OpenXmlCompositeElement compositeElement)
      SetValueToOpenXmlProperty(compositeElement);
  }

  /// <summary>
  /// Sets the value of this setting to the corresponding properties of the specified
  /// of the specified OpenXml leaf element.
  /// </summary>
  private void SetValueToOpenXmlProperty(DX.OpenXmlLeafElement openXmlSettingElement)
  {
    if (openXmlSettingElement is DXWP.OnOffType onOffTypeElement)
      onOffTypeElement.Val = Value?.ToBoolean();
    else
    if (openXmlSettingElement is DXWP.StringType stringTypeElement)
      stringTypeElement.Val = Value?.ToString();
    else
    if (openXmlSettingElement is DXWP.NonNegativeShortType nonNegativeShortTypeElement)
      nonNegativeShortTypeElement.Val = (Int16?)(Value?.ToUInt16());
    else
    {
      foreach (var propertyInfo in typeof(CustomProperty).GetProperties(BindingFlags.Instance | BindingFlags.Public | BindingFlags.DeclaredOnly))
      {
        if (propertyInfo.PropertyType == typeof(DX.StringValue))
          continue;
        var value = propertyInfo.GetValue(this);
        propertyInfo.SetValue(openXmlSettingElement, value);
      }
    }
  }

  /// <summary>
  /// Sets the value of this setting to the corresponding properties of the specified
  /// OpenXml composite element.
  /// </summary>
  private void SetValueToOpenXmlProperty(DX.OpenXmlCompositeElement openXmlSettingElement)
  {
    foreach (var propertyInfo in typeof(CustomProperty).GetProperties())
    {
      var value = propertyInfo.GetValue(this);
      propertyInfo.SetValue(openXmlSettingElement, value);
    }
  }
}