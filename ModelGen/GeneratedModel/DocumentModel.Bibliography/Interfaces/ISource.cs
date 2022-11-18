namespace DocumentModel.Bibliography;

/// <summary>
/// Source.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Bibliography.IAuthorList))]
[ChildElementInfo(typeof(DocumentModel.Bibliography.ISourceType))]
[ChildElementInfo(typeof(DocumentModel.Bibliography.IAbbreviatedCaseNumber))]
[ChildElementInfo(typeof(DocumentModel.Bibliography.IAlbumTitle))]
[ChildElementInfo(typeof(DocumentModel.Bibliography.IBookTitle))]
[ChildElementInfo(typeof(DocumentModel.Bibliography.IBroadcaster))]
[ChildElementInfo(typeof(DocumentModel.Bibliography.IBroadcastTitle))]
[ChildElementInfo(typeof(DocumentModel.Bibliography.ICaseNumber))]
[ChildElementInfo(typeof(DocumentModel.Bibliography.IChapterNumber))]
[ChildElementInfo(typeof(DocumentModel.Bibliography.ICity))]
[ChildElementInfo(typeof(DocumentModel.Bibliography.IComments))]
[ChildElementInfo(typeof(DocumentModel.Bibliography.IConferenceName))]
[ChildElementInfo(typeof(DocumentModel.Bibliography.ICountryRegion))]
[ChildElementInfo(typeof(DocumentModel.Bibliography.ICourt))]
[ChildElementInfo(typeof(DocumentModel.Bibliography.IDay))]
[ChildElementInfo(typeof(DocumentModel.Bibliography.IDayAccessed))]
[ChildElementInfo(typeof(DocumentModel.Bibliography.IDepartment))]
[ChildElementInfo(typeof(DocumentModel.Bibliography.IDistributor))]
[ChildElementInfo(typeof(DocumentModel.Bibliography.IEdition))]
[ChildElementInfo(typeof(DocumentModel.Bibliography.IGuidString))]
[ChildElementInfo(typeof(DocumentModel.Bibliography.IInstitution))]
[ChildElementInfo(typeof(DocumentModel.Bibliography.IInternetSiteTitle))]
[ChildElementInfo(typeof(DocumentModel.Bibliography.IIssue))]
[ChildElementInfo(typeof(DocumentModel.Bibliography.IJournalName))]
[ChildElementInfo(typeof(DocumentModel.Bibliography.ILcId))]
[ChildElementInfo(typeof(DocumentModel.Bibliography.IMedium))]
[ChildElementInfo(typeof(DocumentModel.Bibliography.IMonth))]
[ChildElementInfo(typeof(DocumentModel.Bibliography.IMonthAccessed))]
[ChildElementInfo(typeof(DocumentModel.Bibliography.INumberVolumes))]
[ChildElementInfo(typeof(DocumentModel.Bibliography.IPages))]
[ChildElementInfo(typeof(DocumentModel.Bibliography.IPatentNumber))]
[ChildElementInfo(typeof(DocumentModel.Bibliography.IPeriodicalTitle))]
[ChildElementInfo(typeof(DocumentModel.Bibliography.IProductionCompany))]
[ChildElementInfo(typeof(DocumentModel.Bibliography.IPublicationTitle))]
[ChildElementInfo(typeof(DocumentModel.Bibliography.IPublisher))]
[ChildElementInfo(typeof(DocumentModel.Bibliography.IRecordingNumber))]
[ChildElementInfo(typeof(DocumentModel.Bibliography.IReferenceOrder))]
[ChildElementInfo(typeof(DocumentModel.Bibliography.IReporter))]
[ChildElementInfo(typeof(DocumentModel.Bibliography.IShortTitle))]
[ChildElementInfo(typeof(DocumentModel.Bibliography.IStandardNumber))]
[ChildElementInfo(typeof(DocumentModel.Bibliography.IStateProvince))]
[ChildElementInfo(typeof(DocumentModel.Bibliography.IStation))]
[ChildElementInfo(typeof(DocumentModel.Bibliography.ITag))]
[ChildElementInfo(typeof(DocumentModel.Bibliography.ITheater))]
[ChildElementInfo(typeof(DocumentModel.Bibliography.IThesisType))]
[ChildElementInfo(typeof(DocumentModel.Bibliography.ITitle))]
[ChildElementInfo(typeof(DocumentModel.Bibliography.IPatentType))]
[ChildElementInfo(typeof(DocumentModel.Bibliography.IUrlString))]
[ChildElementInfo(typeof(DocumentModel.Bibliography.IVersion))]
[ChildElementInfo(typeof(DocumentModel.Bibliography.IVolume))]
[ChildElementInfo(typeof(DocumentModel.Bibliography.IYear))]
[ChildElementInfo(typeof(DocumentModel.Bibliography.IYearAccessed))]
public interface ISource // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Abbreviated Case Number.
  /// </summary>
  public IAbbreviatedCaseNumber? AbbreviatedCaseNumber { get ; set; }
  
  /// <summary>
  /// Album Title.
  /// </summary>
  public IAlbumTitle? AlbumTitle { get ; set; }
  
  /// <summary>
  /// Contributors List.
  /// </summary>
  public DocumentModel.Bibliography.IAuthorList? AuthorList { get ; set; }
  
  /// <summary>
  /// Book Title.
  /// </summary>
  public IBookTitle? BookTitle { get ; set; }
  
  /// <summary>
  /// Broadcaster.
  /// </summary>
  public IBroadcaster? Broadcaster { get ; set; }
  
  /// <summary>
  /// Broadcast Title.
  /// </summary>
  public IBroadcastTitle? BroadcastTitle { get ; set; }
  
  /// <summary>
  /// Case Number.
  /// </summary>
  public ICaseNumber? CaseNumber { get ; set; }
  
  /// <summary>
  /// Chapter Number.
  /// </summary>
  public IChapterNumber? ChapterNumber { get ; set; }
  
  /// <summary>
  /// City.
  /// </summary>
  public ICity? City { get ; set; }
  
  /// <summary>
  /// Comments.
  /// </summary>
  public DocumentModel.Bibliography.IComments? Comments { get ; set; }
  
  /// <summary>
  /// Conference or Proceedings Name.
  /// </summary>
  public IConferenceName? ConferenceName { get ; set; }
  
  /// <summary>
  /// Country or Region.
  /// </summary>
  public ICountryRegion? CountryRegion { get ; set; }
  
  /// <summary>
  /// Court.
  /// </summary>
  public ICourt? Court { get ; set; }
  
  /// <summary>
  /// Day.
  /// </summary>
  public IDay? Day { get ; set; }
  
  /// <summary>
  /// Day Accessed.
  /// </summary>
  public IDayAccessed? DayAccessed { get ; set; }
  
  /// <summary>
  /// Department.
  /// </summary>
  public IDepartment? Department { get ; set; }
  
  /// <summary>
  /// Distributor.
  /// </summary>
  public IDistributor? Distributor { get ; set; }
  
  /// <summary>
  /// Editor.
  /// </summary>
  public IEdition? Edition { get ; set; }
  
  /// <summary>
  /// GUID.
  /// </summary>
  public IGuidString? GuidString { get ; set; }
  
  /// <summary>
  /// Institution.
  /// </summary>
  public IInstitution? Institution { get ; set; }
  
  /// <summary>
  /// Internet Site Title.
  /// </summary>
  public IInternetSiteTitle? InternetSiteTitle { get ; set; }
  
  /// <summary>
  /// Issue.
  /// </summary>
  public IIssue? Issue { get ; set; }
  
  /// <summary>
  /// Journal Name.
  /// </summary>
  public IJournalName? JournalName { get ; set; }
  
  /// <summary>
  /// Locale ID.
  /// </summary>
  public ILcId? LcId { get ; set; }
  
  /// <summary>
  /// Medium.
  /// </summary>
  public IMedium? Medium { get ; set; }
  
  /// <summary>
  /// Month.
  /// </summary>
  public IMonth? Month { get ; set; }
  
  /// <summary>
  /// Month Accessed.
  /// </summary>
  public IMonthAccessed? MonthAccessed { get ; set; }
  
  /// <summary>
  /// Number of Volumes.
  /// </summary>
  public INumberVolumes? NumberVolumes { get ; set; }
  
  /// <summary>
  /// Pages.
  /// </summary>
  public DocumentModel.Bibliography.IPages? Pages { get ; set; }
  
  /// <summary>
  /// Patent Number.
  /// </summary>
  public IPatentNumber? PatentNumber { get ; set; }
  
  /// <summary>
  /// Periodical Title.
  /// </summary>
  public IPeriodicalTitle? PeriodicalTitle { get ; set; }
  
  /// <summary>
  /// Production Company.
  /// </summary>
  public IProductionCompany? ProductionCompany { get ; set; }
  
  /// <summary>
  /// Publication Title.
  /// </summary>
  public IPublicationTitle? PublicationTitle { get ; set; }
  
  /// <summary>
  /// Publisher.
  /// </summary>
  public IPublisher? Publisher { get ; set; }
  
  /// <summary>
  /// Recording Number.
  /// </summary>
  public IRecordingNumber? RecordingNumber { get ; set; }
  
  /// <summary>
  /// Reference Order.
  /// </summary>
  public IReferenceOrder? ReferenceOrder { get ; set; }
  
  /// <summary>
  /// Reporter.
  /// </summary>
  public IReporter? Reporter { get ; set; }
  
  /// <summary>
  /// Source Type.
  /// </summary>
  public ISourceType? SourceType { get ; set; }
  
  /// <summary>
  /// Short Title.
  /// </summary>
  public IShortTitle? ShortTitle { get ; set; }
  
  /// <summary>
  /// Standard Number.
  /// </summary>
  public IStandardNumber? StandardNumber { get ; set; }
  
  /// <summary>
  /// State or Province.
  /// </summary>
  public IStateProvince? StateProvince { get ; set; }
  
  /// <summary>
  /// Station.
  /// </summary>
  public IStation? Station { get ; set; }
  
  /// <summary>
  /// Tag.
  /// </summary>
  public DocumentModel.Bibliography.ITag? Tag { get ; set; }
  
  /// <summary>
  /// Theater.
  /// </summary>
  public ITheater? Theater { get ; set; }
  
  /// <summary>
  /// Thesis Type.
  /// </summary>
  public IThesisType? ThesisType { get ; set; }
  
  /// <summary>
  /// Title.
  /// </summary>
  public DocumentModel.Bibliography.ITitle? Title { get ; set; }
  
  /// <summary>
  /// Type.
  /// </summary>
  public IPatentType? PatentType { get ; set; }
  
  /// <summary>
  /// URL.
  /// </summary>
  public IUrlString? UrlString { get ; set; }
  
  /// <summary>
  /// Version.
  /// </summary>
  public IVersion? Version { get ; set; }
  
  /// <summary>
  /// Volume.
  /// </summary>
  public IVolume? Volume { get ; set; }
  
  /// <summary>
  /// Year.
  /// </summary>
  public IYear? Year { get ; set; }
  
  /// <summary>
  /// Year Accessed.
  /// </summary>
  public IYearAccessed? YearAccessed { get ; set; }
  
}
