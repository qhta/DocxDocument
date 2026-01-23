namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents caption information for a WordprocessingML document, including caption definitions and automatic captioning rules.
/// </summary>
public partial class Captions : ModelElement<DXW.Captions>
{
    /// <summary>
    /// Contains the collection of caption format definitions for different object types.
    /// </summary>
    [OpenXmlLoadData(nameof(LoadCaptionsInOpenXml))]
    [OpenXmlUpdateData(nameof(UpdateCaptionDefinitionsInOpenXml))]
    /// <summary>
    /// Contains the collection of caption format definitions for different object types.
    /// </summary>
    [OpenXmlElement(typeof(DXW.Captions))]
    public CaptionDefinitions? CaptionDefinitions { get => _CaptionDefinitions; set => UpdateField(ref _CaptionDefinitions, value, nameof(CaptionDefinitions)); }

    private CaptionDefinitions? _CaptionDefinitions;
    /// <summary>
    /// Updates the caption definitions in the specified Open XML <see cref = "DXW.Captions"/> element to match the current
    /// set of caption definitions.
    /// </summary>
    /// <remarks>This method removes all existing <see cref = "DXW.Caption"/> child elements from <paramref 
    ///name = "wordCaptions"/> and appends new caption definitions based on the current <c>CaptionDefinitions</c>
    /// collection. If <c>CaptionDefinitions</c> is null, no changes are made.</remarks>
    /// <param name = "wordCaptions">The <see cref = "DXW.Captions"/> element whose child caption definitions will be replaced. Cannot be null.</param>
    public void UpdateCaptionDefinitionsInOpenXml(DXW.Captions wordCaptions)
    {
        wordCaptions.RemoveAllChildren<DXW.Caption>();
        if (CaptionDefinitions == null)
            return;
        foreach (var item in CaptionDefinitions)
        {
            var newChild = OpenXmlComplexTypeConverter.ConvertObjectToOpenXml(item, typeof(DXW.Caption));
            if (newChild is DXW.Caption caption)
                wordCaptions.AppendChild(caption);
        }
    }

    /// <summary>
    /// Loads caption definitions from the specified Open XML captions element into the current collection.
    /// </summary>
    /// <remarks>This method parses each <see cref = "DXW.Caption"/> element within the provided <paramref 
    ///name = "wordCaptions"/> and adds the corresponding caption definitions to the <c>CaptionDefinitions</c> collection.
    /// Existing items in the collection are preserved, and new items are appended. If the collection is null, it will be
    /// initialized.</remarks>
    /// <param name = "wordCaptions">The Open XML captions element containing one or more caption definitions to load. Cannot be null.</param>
    public void LoadCaptionsInOpenXml(DXW.Captions wordCaptions)
    {
        foreach (var openXmlItem in wordCaptions.Elements<DXW.Caption>())
        {
            var modelItem = OpenXmlComplexTypeConverter.ConvertObjectFromOpenXml(openXmlItem, typeof(DMW.CaptionDefinition));
            if (modelItem is DMW.CaptionDefinition captionDefinition)
            {
                CaptionDefinitions ??= new CaptionDefinitions();
                CaptionDefinitions.Add(captionDefinition);
            }
        }
    }

    /// <summary>
    /// Contains the collection of automatic captioning rules for objects in the document.
    /// </summary>
    [OpenXmlLoadData(nameof(LoadAutoCaptionsInOpenXml))]
    [OpenXmlUpdateData(nameof(UpdateAutoCaptionsInOpenXml))]
    /// <summary>
    /// Contains the collection of automatic captioning rules for objects in the document.
    /// </summary>
    [OpenXmlElement(typeof(DXW.Captions))]
    public AutoCaptions? AutoCaptions { get => _AutoCaptions; set => UpdateField(ref _AutoCaptions, value, nameof(AutoCaptions)); }

    private AutoCaptions? _AutoCaptions;
    /// <summary>
    /// Updates the specified Open XML captions collection to reflect the current set of automatic captions.
    /// </summary>
    /// <remarks>If there are no automatic captions to apply, all existing automatic captions are removed from the
    /// collection. This method does not modify other types of captions in the collection.</remarks>
    /// <param name = "wordCaptions">The Open XML captions collection to update. All existing automatic captions in this collection are removed and
    /// replaced with the current set.</param>
    public void UpdateAutoCaptionsInOpenXml(DXW.Captions wordCaptions)
    {
        wordCaptions.RemoveAllChildren<DXW.AutoCaptions>();
        if (AutoCaptions == null)
            return;
        if (AutoCaptions.Count > 0)
        {
            var modelAutoCaptions = new DXW.AutoCaptions();
            foreach (var modelItem in AutoCaptions)
            {
                var openXmlItem = OpenXmlComplexTypeConverter.ConvertObjectToOpenXml(modelItem, typeof(DXW.AutoCaption));
                if (openXmlItem is DXW.AutoCaption autoCaption)
                    modelAutoCaptions.AppendChild(autoCaption);
            }

            wordCaptions.AppendChild(modelAutoCaptions);
        }
    }

    /// <summary>
    /// Loads automatic caption definitions from the specified Open XML captions collection into the current model.
    /// </summary>
    /// <param name = "wordCaptions"></param>
    public void LoadAutoCaptionsInOpenXml(DXW.Captions wordCaptions)
    {
        var autoCaptions = wordCaptions.Elements<DXW.AutoCaptions>().FirstOrDefault();
        if (autoCaptions != null)
        {
            foreach (var openXmlItem in autoCaptions.Elements<DXW.AutoCaption>())
            {
                var modelItem = OpenXmlComplexTypeConverter.ConvertObjectFromOpenXml(openXmlItem, typeof(DMW.AutoCaption));
                if (modelItem is DMW.AutoCaption autoCaption)
                {
                    AutoCaptions ??= new AutoCaptions();
                    AutoCaptions.Add(autoCaption);
                }
            }
        }
    }
}