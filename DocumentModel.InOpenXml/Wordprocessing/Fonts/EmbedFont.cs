namespace DocumentModel.Wordprocessing;
/// <summary>
/// Relationship to embedded font part where embedded font data is stored.
/// This relationship is used to link font definitions in the document to their corresponding embedded font data parts, allowing for proper rendering of fonts that are not available on the user's system.
/// </summary>
[OpenXmlType(typeof(DXW.FontRelationshipType))]
[XmlRoot("EmbeddedFont", Namespace = "DocumentModel.Wordprocessing")]
public partial class EmbedFont : ModelElement<DXW.FontRelationshipType>
{
  /// <summary>
  /// Identifier of the relationship, corresponding to the 'r:id' attribute in the Open XML schema.
  /// This property is used to link the relationship to a specific part or resource within the document.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.FontRelationshipType.Id))]
  public string? Id { get => _Id; set => UpdateField(ref _Id, value, nameof(Id)); }
  private string? _Id;

  /// <summary>
  /// Specifies the key which was used to obfuscate this embedded font. This key can be used
  /// to retrieve the embedded font for the purposes of viewing this WordprocessingML
  ///  document only, using the algorithm described in §17.8.1.    
  /// </summary>
  [OpenXmlProperty(nameof(DXW.FontRelationshipType.FontKey))]
  public Guid? FontKey { get => _FontKey; set => UpdateField(ref _FontKey, value, nameof(FontKey)); }
  private Guid? _FontKey;

  /// <summary>
  /// Specifies that the embedded font targeted by the id attribute has been subsetted.
  /// Subsetting is a mechanism by which only the glyphs used in the contents of this
  /// WordprocessingML document are stored in an embedded font, in order to prevent the
  /// file from becoming unnecessarily large from the use of a small number of glyphs from a
  /// large embedded font.  
  /// </summary>
  [OpenXmlProperty(nameof(DXW.FontRelationshipType.Subsetted))]
  public bool? Subsetted { get => _Subsetted; set => UpdateField(ref _Subsetted, value, nameof(Subsetted)); }
  private bool? _Subsetted;

  /// <summary>
  /// Represents the embedded font data as a Base64-encoded binary string. This property allows for the storage and retrieval of the actual font data associated with the embedded font relationship, enabling the document to include custom fonts that may not be available on the user's system. The data is typically obfuscated using the specified FontKey to protect against unauthorized use, and can be decoded and de-obfuscated to access the original font data when needed for rendering or other operations.
  /// </summary>
  public Base64Binary? FontData
  {
    get => _FontData ?? LoadFontData();
    set { UpdateField(ref _FontData, value, nameof(FontData)); UpdateFontData(); }
  }
  private Base64Binary? _FontData;

  /// <summary>
  /// Loads the embedded font data from the associated part in the WordprocessingDocument, applying de-obfuscation using the FontKey if necessary. This method retrieves the font data as a Base64-encoded binary string, allowing for the proper rendering of the embedded font in the document. If the Id or FontKey properties are not set, an ApplicationException is thrown to indicate that the necessary information for loading the font data is missing.
  /// </summary>
  /// <returns>The Base64-encoded font data.</returns>
  /// <exception cref="ApplicationException">Thrown when the Id or FontKey properties are null.</exception>
  public Base64Binary? LoadFontData()
  {
    if (WordprocessingDocument == null)
      return null;
    if (Id == null)
      throw new ApplicationException("The Id property is null in LoadFontData.");
    if (FontKey == null)
      throw new ApplicationException("The FontKey property is null in LoadFontData.");
    var mainPart = WordprocessingDocument.MainDocumentPart;
    var fontTablePart = mainPart?.FontTablePart;
    if (fontTablePart == null)
      return null;
    var fontPart = fontTablePart.GetPartById(Id);
    using (var stream = fontPart.GetStream())
    {
      using (var memoryStream = new MemoryStream())
      {
        stream.CopyTo(memoryStream);
        var fontBytes = memoryStream.ToArray();
        if (FontKey != null)
        {
          ObfuscateDeobfuscate(fontBytes, FontKey.Value);
        }
        return new Base64Binary(fontBytes);
      }
    }
  }

  /// <summary>
  /// Updates the embedded font data in the associated part of the WordprocessingDocument with the current FontData value, applying obfuscation using the FontKey if necessary. This method ensures that the embedded font data is properly stored in the document, allowing for correct rendering of the font when the document is opened. If the Id property is not set, a new relationship ID is generated and assigned to link the font data to the appropriate part in the document. The method returns the Base64-encoded font data that was updated in the document.
  /// </summary>
  /// <returns></returns>
  public void UpdateFontData()
  {
    if (WordprocessingDocument == null)
      return;

    if (FontData != null)
    {
      if (Id == null)
      {
        var fontTable = WordprocessingDocument.GetFontTable();
        var allEmbedFontIds = fontTable.OfType<DX.OpenXmlCompositeElement>().SelectMany(o => o.Elements())
          .Where(element => element is DXW.FontRelationshipType).Select(r => ((DXW.FontRelationshipType)r).Id?.Value)
          .ToList();
        var highestEmbedFontIdNumber = allEmbedFontIds.Count == 0
          ? 0
          : allEmbedFontIds.Where(id => id != null && id.StartsWith("rId"))
            .Select(id => int.TryParse(id!.Substring(3), out var number) ? number : 0).DefaultIfEmpty(0).Max();
        var newId = "rId" + (highestEmbedFontIdNumber + 1);
        Id = newId;
      }

      var mainPart = WordprocessingDocument.MainDocumentPart ?? WordprocessingDocument.AddMainDocumentPart();
      var fontTablePart = mainPart.FontTablePart ?? mainPart.AddNewPart<DXPP.FontTablePart>();
      fontTablePart.Fonts ??= new DXW.Fonts();
      if (!fontTablePart.TryGetPartById(Id, out var fontPart))
      {
        fontPart = fontTablePart.AddNewPart<DXPP.FontPart>(Id);
      }

      FontKey ??= Guid.NewGuid();

      using (var stream = fontPart.GetStream())
      {
        var fontBytes = (byte[])FontData;
        if (FontKey != null)
        {
          ObfuscateDeobfuscate(fontBytes, FontKey.Value);
        }
        using (var memoryStream = new MemoryStream(fontBytes))
        {
          memoryStream.CopyTo(stream);
        }
      }
    }
  }

  /// <summary>
  /// Obfuscates or de-obfuscates the provided font data using the specified key.
  /// The method applies a reversible transformation to the font data based on the FontKey,
  /// allowing for the protection of embedded font data in the document.
  /// The obfuscation algorithm involves XORing first 32 bytes of the font data
  /// with corresponding bytes derived from the FontKey,
  /// which is reversed to ensure that applying the same method again will restore the original font data.
  /// </summary>
  /// <remarks>
  ///   This mechanism is used to prevent unauthorized access to embedded font data while still allowing it to be properly rendered when needed.
  /// </remarks>
  /// <param name="data">The font data to be obfuscated or de-obfuscated.</param>
  /// <param name="key">The key used for the obfuscation or de-obfuscation process.</param>
  private void ObfuscateDeobfuscate(byte[] data, Guid key)
  {
    var guidBytes = key.ToByteArray();
    var revertedGuidBytes = new byte[guidBytes.Length];
    for (int i = 0; i < guidBytes.Length; i++)
    {
      revertedGuidBytes[i] = guidBytes[^(i + 1)];
    }
    for (int dataIndex = 0; dataIndex < data.Length && dataIndex < 32; dataIndex++)
    {
      int keyIndex = dataIndex % 16;
      data[dataIndex] ^= revertedGuidBytes[keyIndex];
    }
  }

  ///// <summary>
  ///// Attaches the specified WordprocessingDocument and loads its data into the current instance.
  ///// </summary>
  ///// <param name = "wordprocessingDocument">The WordprocessingDocument to attach and load.</param>
  //public override void AttachAndLoad(DX.WordprocessingDocument wordprocessingDocument)
  //{
  //  base.AttachAndLoad(wordprocessingDocument);
  //  if (WordprocessingDocument == null)
  //    return;
  //  LoadData(WordprocessingDocument);
  //}
  ///// <summary>
  ///// Attaches the specified WordprocessingDocument and updates the associated data.
  ///// </summary>
  ///// <param name = "wordprocessingDocument">The WordprocessingDocument to attach and use for updating data.</param>
  //public override void AttachAndUpdate(DX.WordprocessingDocument wordprocessingDocument)
  //{
  //  base.AttachAndUpdate(wordprocessingDocument);
  //  if (WordprocessingDocument == null)
  //    return;
  //  UpdateData(WordprocessingDocument);
  //}
  ///// <summary>
  ///// Updates the internal data by loading information from the specified Open XML element.
  ///// </summary>
  ///// <remarks>If the associated Document is not available, the method does not perform any
  ///// update.</remarks>
  ///// <param name = "openXmlObject">The Open XML element from which to load data. This parameter must represent a valid Open XML element associated
  ///// with a Document.</param>
  //public override void UpdateData(object openXmlObject)
  //{
  //  if (WordprocessingDocument == null)
  //    return;
  //  UpdateData(WordprocessingDocument);
  //}
  ///// <summary>
  ///// Loads data from the specified Document into the current instance.
  ///// </summary>
  ///// <remarks>This method updates the Id and Uri properties based on the relationship information found in the
  ///// provided document, if available. If the relevant relationship is not present, the properties remain
  ///// unchanged.</remarks>
  ///// <param name = "document">The Document from which to load data.</param>
  //public virtual void LoadData(DX.WordprocessingDocument document)
  //{
  //  DXW.FontRelationshipType? updatedElement = (DXW.FontRelationshipType?)GetUpdatableElement();
  //  if (updatedElement != null)
  //  {
  //    Id = updatedElement.Id;
  //      FontKey = updatedElement.FontKey;
  //  }
  //}
  ///// <summary>
  ///// Updates the specified Document with the current Id and Uri values.
  ///// </summary>
  ///// <remarks>This method sets the Id property and, if specified, the Uri property on the relationship element
  ///// within the provided document. The document must contain a relationship element compatible with the update
  ///// operation.</remarks>
  ///// <param name = "document">The Document to update with new relationship data. Cannot be null.</param>
  //public virtual void UpdateData(DX.WordprocessingDocument document)
  //{
  //  DXW.FontRelationshipType? updatedElement = (DXW.FontRelationshipType?)GetUpdatableElement();
  //  if (updatedElement != null)
  //  {
  //    updatedElement.Id = Id;
  //  }
  //}
}