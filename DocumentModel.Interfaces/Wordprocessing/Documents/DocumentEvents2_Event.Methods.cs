namespace DocumentModel.Wordprocessing;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.documentevents2_event?view=word-pia"/>
public partial interface DocumentEvents2_Event
{
  /// <summary>
  /// A handler to the New event.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.documentevents2_event.add_new?view=word-pia"/>
  public event App.DocumentEvents2_NewEventHandler New;

  /// <summary>
  /// A handler to the Open event.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.documentevents2_event.add_open?view=word-pia"/>
  public event App.DocumentEvents2_OpenEventHandler Open;


  /// <summary>
  /// A handler to the Close event.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.documentevents2_event.add_close?view=word-pia"/>
  public event App.DocumentEvents2_CloseEventHandler Close;
  
  /// <summary>
  /// A handler to the Sync event.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.documentevents2_event.add_sync?view=word-pia"/>
  public event App.DocumentEvents2_SyncEventHandler Sync;

  /// <summary>
  /// A handler to the XMLAfterInsert event.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.documentevents2_event.add_xmlafterinsert?view=word-pia"/>
  public event App.DocumentEvents2_XMLAfterInsertEventHandler XMLAfterInsert;

  /// <summary>
  /// A handler to the XMLBeforeDelete event.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.documentevents2_event.add_xmlbeforedelete?view=word-pia"/>
  public event App.DocumentEvents2_XMLBeforeDeleteEventHandler XMLBeforeDelete;

  /// <summary>
  /// A handler to the ContentControlAfterAdd event.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.documentevents2_event.add_contentcontrolafteradd?view=word-pia"/>
  public event App.DocumentEvents2_ContentControlAfterAddEventHandler ContentControlAfterAdd;

  /// <summary>
  /// A handler to the ContentControlBeforeDelete event.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.documentevents2_event.add_contentcontrolbeforedelete?view=word-pia"/>
  public event App.DocumentEvents2_ContentControlBeforeDeleteEventHandler ContentControlBeforeDelete;

  /// <summary>
  /// A handler to the ContentControlOnExit event.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.documentevents2_event.add_contentcontrolonexit?view=word-pia"/>
  public event App.DocumentEvents2_ContentControlOnExitEventHandler ContentControlOnExit;

  /// <summary>
  /// A handler to the ContentControlOnEnter event.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.documentevents2_event.add_contentcontrolonenter?view=word-pia"/>
  public event App.DocumentEvents2_ContentControlOnEnterEventHandler ContentControlOnEnter;

  /// <summary>
  /// A handler to the ContentControlBeforeStoreUpdate event.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.documentevents2_event.add_contentcontrolbeforestoreupdate?view=word-pia"/>
  public event App.DocumentEvents2_ContentControlBeforeStoreUpdateEventHandler ContentControlBeforeStoreUpdate;

  /// <summary>
  /// A handler to the ContentControlBeforeContentUpdate event.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.documentevents2_event.add_contentcontrolbeforecontentupdate?view=word-pia"/>
  public event App.DocumentEvents2_ContentControlBeforeContentUpdateEventHandler ContentControlBeforeContentUpdate;

  /// <summary>
  /// A handler to the BuildingBlockInsert event.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.documentevents2_event.add_buildingblockinsert?view=word-pia"/>
  public event App.DocumentEvents2_BuildingBlockInsertEventHandler BuildingBlockInsert;

}
