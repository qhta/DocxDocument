namespace DocumentModel.Interop.Word;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.documentevents2_event?view=word-pia"/>
public partial interface DocumentEvents2_Event
{
  /// <summary>
  /// Subscribes a handler to the New event.
  /// </summary>
  /// <param name="param1">The delegate to invoke when the New event is raised.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.documentevents2_event.add_new?view=word-pia"/>
  public void add_New(DocumentEvents2_NewEventHandler param1);

  /// <summary>
  /// Unsubscribes a handler from the New event.
  /// </summary>
  /// <param name="param1">The delegate to remove from the New event.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.documentevents2_event.remove_new?view=word-pia"/>
  public void remove_New(DocumentEvents2_NewEventHandler param1);

  /// <summary>
  /// Subscribes a handler to the Open event.
  /// </summary>
  /// <param name="param1">The delegate to invoke when the Open event is raised.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.documentevents2_event.add_open?view=word-pia"/>
  public void add_Open(DocumentEvents2_OpenEventHandler param1);

  /// <summary>
  /// Unsubscribes a handler from the Open event.
  /// </summary>
  /// <param name="param1">The delegate to remove from the Open event.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.documentevents2_event.remove_open?view=word-pia"/>
  public void remove_Open(DocumentEvents2_OpenEventHandler param1);

  /// <summary>
  /// Subscribes a handler to the Close event.
  /// </summary>
  /// <param name="param1">The delegate to invoke when the Close event is raised.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.documentevents2_event.add_close?view=word-pia"/>
  public void add_Close(DocumentEvents2_CloseEventHandler param1);

  /// <summary>
  /// Unsubscribes a handler from the Close event.
  /// </summary>
  /// <param name="param1">The delegate to remove from the Close event.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.documentevents2_event.remove_close?view=word-pia"/>
  public void remove_Close(DocumentEvents2_CloseEventHandler param1);

  /// <summary>
  /// Subscribes a handler to the Sync event.
  /// </summary>
  /// <param name="param1">The delegate to invoke when the Sync event is raised.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.documentevents2_event.add_sync?view=word-pia"/>
  public void add_Sync(DocumentEvents2_SyncEventHandler param1);

  /// <summary>
  /// Unsubscribes a handler from the Sync event.
  /// </summary>
  /// <param name="param1">The delegate to remove from the Sync event.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.documentevents2_event.remove_sync?view=word-pia"/>
  public void remove_Sync(DocumentEvents2_SyncEventHandler param1);

  /// <summary>
  /// Subscribes a handler to the XMLAfterInsert event.
  /// </summary>
  /// <param name="param1">The delegate to invoke when the XMLAfterInsert event is raised.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.documentevents2_event.add_xmlafterinsert?view=word-pia"/>
  public void add_XMLAfterInsert(DocumentEvents2_XMLAfterInsertEventHandler param1);

  /// <summary>
  /// Unsubscribes a handler from the XMLAfterInsert event.
  /// </summary>
  /// <param name="param1">The delegate to remove from the XMLAfterInsert event.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.documentevents2_event.remove_xmlafterinsert?view=word-pia"/>
  public void remove_XMLAfterInsert(DocumentEvents2_XMLAfterInsertEventHandler param1);

  /// <summary>
  /// Subscribes a handler to the XMLBeforeDelete event.
  /// </summary>
  /// <param name="param1">The delegate to invoke when the XMLBeforeDelete event is raised.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.documentevents2_event.add_xmlbeforedelete?view=word-pia"/>
  public void add_XMLBeforeDelete(DocumentEvents2_XMLBeforeDeleteEventHandler param1);

  /// <summary>
  /// Unsubscribes a handler from the XMLBeforeDelete event.
  /// </summary>
  /// <param name="param1">The delegate to remove from the XMLBeforeDelete event.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.documentevents2_event.remove_xmlbeforedelete?view=word-pia"/>
  public void remove_XMLBeforeDelete(DocumentEvents2_XMLBeforeDeleteEventHandler param1);

  /// <summary>
  /// Subscribes a handler to the ContentControlAfterAdd event.
  /// </summary>
  /// <param name="param1">The delegate to invoke when the ContentControlAfterAdd event is raised.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.documentevents2_event.add_contentcontrolafteradd?view=word-pia"/>
  public void add_ContentControlAfterAdd(DocumentEvents2_ContentControlAfterAddEventHandler param1);

  /// <summary>
  /// Unsubscribes a handler from the ContentControlAfterAdd event.
  /// </summary>
  /// <param name="param1">The delegate to remove from the ContentControlAfterAdd event.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.documentevents2_event.remove_contentcontrolafteradd?view=word-pia"/>
  public void remove_ContentControlAfterAdd(DocumentEvents2_ContentControlAfterAddEventHandler param1);

  /// <summary>
  /// Subscribes a handler to the ContentControlBeforeDelete event.
  /// </summary>
  /// <param name="param1">The delegate to invoke when the ContentControlBeforeDelete event is raised.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.documentevents2_event.add_contentcontrolbeforedelete?view=word-pia"/>
  public void add_ContentControlBeforeDelete(DocumentEvents2_ContentControlBeforeDeleteEventHandler param1);

  /// <summary>
  /// Unsubscribes a handler from the ContentControlBeforeDelete event.
  /// </summary>
  /// <param name="param1">The delegate to remove from the ContentControlBeforeDelete event.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.documentevents2_event.remove_contentcontrolbeforedelete?view=word-pia"/>
  public void remove_ContentControlBeforeDelete(DocumentEvents2_ContentControlBeforeDeleteEventHandler param1);

  /// <summary>
  /// Subscribes a handler to the ContentControlOnExit event.
  /// </summary>
  /// <param name="param1">The delegate to invoke when the ContentControlOnExit event is raised.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.documentevents2_event.add_contentcontrolonexit?view=word-pia"/>
  public void add_ContentControlOnExit(DocumentEvents2_ContentControlOnExitEventHandler param1);

  /// <summary>
  /// Unsubscribes a handler from the ContentControlOnExit event.
  /// </summary>
  /// <param name="param1">The delegate to remove from the ContentControlOnExit event.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.documentevents2_event.remove_contentcontrolonexit?view=word-pia"/>
  public void remove_ContentControlOnExit(DocumentEvents2_ContentControlOnExitEventHandler param1);

  /// <summary>
  /// Subscribes a handler to the ContentControlOnEnter event.
  /// </summary>
  /// <param name="param1">The delegate to invoke when the ContentControlOnEnter event is raised.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.documentevents2_event.add_contentcontrolonenter?view=word-pia"/>
  public void add_ContentControlOnEnter(DocumentEvents2_ContentControlOnEnterEventHandler param1);

  /// <summary>
  /// Unsubscribes a handler from the ContentControlOnEnter event.
  /// </summary>
  /// <param name="param1">The delegate to remove from the ContentControlOnEnter event.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.documentevents2_event.remove_contentcontrolonenter?view=word-pia"/>
  public void remove_ContentControlOnEnter(DocumentEvents2_ContentControlOnEnterEventHandler param1);

  /// <summary>
  /// Subscribes a handler to the ContentControlBeforeStoreUpdate event.
  /// </summary>
  /// <param name="param1">The delegate to invoke when the ContentControlBeforeStoreUpdate event is raised.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.documentevents2_event.add_contentcontrolbeforestoreupdate?view=word-pia"/>
  public void add_ContentControlBeforeStoreUpdate(DocumentEvents2_ContentControlBeforeStoreUpdateEventHandler param1);

  /// <summary>
  /// Unsubscribes a handler from the ContentControlBeforeStoreUpdate event.
  /// </summary>
  /// <param name="param1">The delegate to remove from the ContentControlBeforeStoreUpdate event.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.documentevents2_event.remove_contentcontrolbeforestoreupdate?view=word-pia"/>
  public void remove_ContentControlBeforeStoreUpdate(DocumentEvents2_ContentControlBeforeStoreUpdateEventHandler param1);

  /// <summary>
  /// Subscribes a handler to the ContentControlBeforeContentUpdate event.
  /// </summary>
  /// <param name="param1">The delegate to invoke when the ContentControlBeforeContentUpdate event is raised.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.documentevents2_event.add_contentcontrolbeforecontentupdate?view=word-pia"/>
  public void add_ContentControlBeforeContentUpdate(DocumentEvents2_ContentControlBeforeContentUpdateEventHandler param1);

  /// <summary>
  /// Unsubscribes a handler from the ContentControlBeforeContentUpdate event.
  /// </summary>
  /// <param name="param1">The delegate to remove from the ContentControlBeforeContentUpdate event.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.documentevents2_event.remove_contentcontrolbeforecontentupdate?view=word-pia"/>
  public void remove_ContentControlBeforeContentUpdate(DocumentEvents2_ContentControlBeforeContentUpdateEventHandler param1);

  /// <summary>
  /// Subscribes a handler to the BuildingBlockInsert event.
  /// </summary>
  /// <param name="param1">The delegate to invoke when the BuildingBlockInsert event is raised.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.documentevents2_event.add_buildingblockinsert?view=word-pia"/>
  public void add_BuildingBlockInsert(DocumentEvents2_BuildingBlockInsertEventHandler param1);

  /// <summary>
  /// Unsubscribes a handler from the BuildingBlockInsert event.
  /// </summary>
  /// <param name="param1">The delegate to remove from the BuildingBlockInsert event.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.documentevents2_event.remove_buildingblockinsert?view=word-pia"/>
  public void remove_BuildingBlockInsert(DocumentEvents2_BuildingBlockInsertEventHandler param1);
}
