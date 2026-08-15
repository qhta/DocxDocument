namespace DocumentModel.Wordprocessing;
/// <summary>
///   Collection of sections in a Word document.
/// </summary>
[OpenXmlType(typeof(Section))]
[DataContract]
[XmlRoot("Sections", Namespace = "DocumentModel.Wordprocessing")]
public class Sections : ModelElementCollection<Section>
{

  /// <summary>
  /// Creates a new instance of the Sections class with the specified parent element.
  /// </summary>
  /// <param name="parent">The parent ModelElement that owns this collection. It must implement IStory interface.</param>
  public Sections(ModelElement parent)
  {
    if (parent is not IStory)
      throw new ArgumentException("Parent must implement IStory interface.", nameof(parent));
    Parent = parent;
    DataSource = parent;
    IsLazyLoadEnabled = true;
  }

  /// <summary>
  /// Gets a value indicating whether the parent IStory element has direct access to its content, which affects how sections are loaded and managed in the collection.
  /// </summary>
  public new bool HasDirectAccess => (Parent as IStory)?.HasDirectAccess == true;

  /// <summary>
  /// Enumerates the sections in the collection lazily, loading them from the parent IStory element as needed.
  /// </summary>
  /// <returns>yield return each Section in the collection.</returns>
  /// <exception cref="ApplicationException">Thrown when the parent does not implement IStory interface.</exception>
  protected override IEnumerable<Section> EnumerateLazy()
  {
    if (IsLazyLoadEnabled && !IsLoading && !IsLoaded)
    {
      SetIsLoading(true);
      if (DataSource is IStory modelBody)
      {
        foreach (var item in modelBody.Items)
        {
          if (item is Paragraph paragraph && paragraph.ParagraphProperties?.SectionProperties is SectionProperties sectionProperties)
          {
            var section = new Section(this, sectionProperties);
            if (!HasDirectAccess) 
              Add(section);
            yield return section;
          }
          else if (item is SectionProperties lastSectionProperties)
          {
            var section = new Section(this, lastSectionProperties);
            if (!HasDirectAccess)
              Add(section);
            yield return section;

            break;
          }
        }
        SetIsLoading(false);
        if (!HasDirectAccess)
          SetIsLoaded(true);
        yield break;
      }
      throw new ApplicationException("Parent must implement IStory interface.");
    }
    foreach (var section in base.Items)
    {
      yield return section;
    }
  }

  /// <summary>
  /// Tries to lazy load sections from the parent IStory element up to the specified index.
  /// If the sections are already loaded or loading, it will not perform any action.
  /// It returns true if all sections up to the specified index are loaded; otherwise, false.
  /// </summary>
  /// <param name="untilIndex">The index up to which sections should be lazy loaded.</param>
  /// <returns>True if all sections up to the specified index are loaded; otherwise, false.</returns>
  public override bool TryLazyLoad(int untilIndex)
  {
    if (IsLazyLoadEnabled && !IsLoading && !IsLoaded)
    {
      //Debug.WriteLine($"TryLazyLoad ({untilIndex}) begin");
      SetIsLoading(true);
      OpenXmlModelConverter.Init();
      var sourceCollection = SourceCollection;
      if (sourceCollection is null)
        throw new ApplicationException("Can't lazy load data because the source collection is null.");
      //Debug.WriteLine($"Lazy loading data for {GetType().Name}");

      int alreadyLoaded = base.Items.Count;


      var sourceArray = sourceCollection.Where(AcceptSourceItem).Skip(alreadyLoaded).ToArray();
      int i;
      for (i = 0; i < sourceArray.Length; i++)
      {
        int justLoading = alreadyLoaded + i;
        if (justLoading > untilIndex)
          break;
        var openXmlItem = sourceArray[i];
        var modelItemType = GetTargetModelItemType(openXmlItem);
        //Debug.WriteLine($"TryLazyLoad {openXmlItem.LocalName}, {modelItemType}, {justLoading}");
        var modelItem = OpenXmlElementConverter.ConvertFrom(openXmlItem, modelItemType);
        if (modelItem is Section item)
        {
          if (!HasDirectAccess)
            Add(item);
        }
        else
        {
          throw new ApplicationException($"Failed to convert OpenXmlElement {openXmlItem} to {modelItemType.Name}");
        }
      }
      SetIsLoading(false);
      if (!HasDirectAccess)
        SetIsLoaded(i == sourceArray.Length);
      //Debug.WriteLine($"TryLazyLoad return {IsLoaded}");
    }
    return IsLoaded;
  }

  /// <summary>
  /// Loads the sections from the parent IStory element.
  /// It iterates through the paragraphs of the parent and creates Section objects for each paragraph that has SectionProperties defined.
  /// At the end, it recognized the last SectionProperties element as a section if it exists.
  /// </summary>
  /// <returns>true if the data was loaded successfully; otherwise, false.</returns>
  public override bool LoadData()
  {
    if (DataSource is IStory modelBody)
    {
      foreach (var item in modelBody.Items)
      {
        if (item is Paragraph paragraph)
          if (paragraph.ParagraphProperties?.SectionProperties is SectionProperties sectionProperties)
          {
            var section = new Section(this, sectionProperties);
            Add(section);
          }
          else if (item is SectionProperties lastSectionProperties)
          {
            var section = new Section(this, lastSectionProperties);
            Add(section);
            break;
          }
      }
      return true;

    }
    return false;
  }

  public override bool UpdateData()
  {
    throw new NotImplementedException();
  }
}