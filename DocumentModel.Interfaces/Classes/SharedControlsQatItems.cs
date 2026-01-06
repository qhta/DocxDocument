namespace DocumentModel;

/// <summary>
/// Represents a collection of custom controls that can be added to the Quick Access Toolbar (QAT)
/// at the application level, shared across all documents. The QAT is a customizable toolbar that provides
/// quick access to frequently used commands, positioned above or below the ribbon.
/// </summary>
/// <remarks>
/// <para>
/// The Quick Access Toolbar (QAT) is a key feature of the Office ribbon interface that allows users
/// to personalize their workspace. Application-level QAT customization through <see cref="SharedControlsQatItems"/>
/// provides controls that persist across all documents and sessions, unlike document-specific QAT items
/// defined in <see cref="DocumentControlsQatItems"/>.
/// </para>
/// <para>
/// Shared (application-level) QAT customization enables:
/// <list type="bullet">
/// <item><description><b>Persistent commands:</b> Controls that remain available regardless of which document is open</description></item>
/// <item><description><b>Global workflows:</b> Provide quick access to application-wide features and tools</description></item>
/// <item><description><b>Add-in integration:</b> Surface add-in commands for easy access across all documents</description></item>
/// <item><description><b>User preferences:</b> Allow applications to suggest commonly used commands</description></item>
/// </list>
/// </para>
/// <para>
/// Shared QAT customization differs from document-level QAT customization:
/// <list type="bullet">
/// <item><description><b>Application-level (SharedControlsQatItems):</b> Controls persist across all documents and sessions, stored in application settings</description></item>
/// <item><description><b>Document-level (DocumentControlsQatItems):</b> Controls appear only when a specific document is open, stored in the document file</description></item>
/// <item><description><b>Scope:</b> Shared controls are ideal for frequently used operations that apply to any document</description></item>
/// <item><description><b>User control:</b> Users can still add, remove, or reorder shared QAT items through the Office UI</description></item>
/// </list>
/// </para>
/// <para>
/// The QAT supports a limited set of control types optimized for single-click operations:
/// <list type="bullet">
/// <item><description><b>Cloned controls:</b> References to existing built-in Office commands (recommended for consistency)</description></item>
/// <item><description><b>Custom buttons:</b> Execute custom actions defined by add-ins or application code</description></item>
/// <item><description><b>Separators:</b> Visually group related commands for better organization</description></item>
/// </list>
/// </para>
/// <para>
/// Unlike the ribbon or context menus, the QAT intentionally has a simplified control model,
/// supporting only basic button controls. Complex controls like galleries, dropdown menus, or
/// toggle buttons are not supported to maintain the QAT's streamlined, single-click nature.
/// </para>
/// <para>
/// Shared QAT customization is particularly valuable for:
/// <list type="bullet">
/// <item><description>Add-ins that provide frequently used commands (Save to Cloud, Export, Custom Format)</description></item>
/// <item><description>Enterprise deployments with standardized command access across all users</description></item>
/// <item><description>Applications that extend Office with specialized features (CRM integration, document generation)</description></item>
/// <item><description>Power user workflows that benefit from quick access to specific tools</description></item>
/// </list>
/// </para>
/// <para>
/// Shared QAT items are typically defined programmatically by Office add-ins or through
/// administrative deployment policies. Users can customize their QAT further by adding built-in
/// Office commands through the UI (right-click commands and select "Add to Quick Access Toolbar").
/// </para>
/// </remarks>
/// <example>
/// <code>
/// // Add a custom button for an add-in command to the shared QAT
/// var sharedQatItems = new SharedControlsQatItems
/// {
///     ButtonRegular = new ButtonRegular
///     {
///         Id = "addInQuickSave",
///         Label = "Quick Save to Cloud",
///         ImageMso = "FileSaveAs",
///         ScreenTip = "Save document to cloud storage",
///         SuperTip = "Quickly save the current document to your cloud storage account",
///         OnAction = "CloudSaveCallback"
///     }
/// };
/// 
/// // Clone a built-in Office command for shared QAT access
/// var sharedQatWithClone = new SharedControlsQatItems
/// {
///     ControlCloneQat = new ControlCloneQat
///     {
///         IdMso = "FilePrintQuick",
///         Visible = true
///     }
/// };
/// 
/// // Add multiple controls with a separator for organization
/// var sharedQatMultiple = new SharedControlsQatItems
/// {
///     ControlCloneQat = new ControlCloneQat 
///     { 
///         IdMso = "Undo" 
///     },
///     Separator = new Separator 
///     { 
///         Id = "standardSeparator",
///         Visible = true 
///     },
///     ButtonRegular = new ButtonRegular
///     {
///         Id = "customExportAll",
///         Label = "Export All",
///         ImageMso = "ExportExcel",
///         OnAction = "ExportAllDocumentsCallback"
///     }
/// };
/// </code>
/// </example>
public interface SharedControlsQatItems
{
  /// <summary>
  /// Gets or sets a reference to a built-in Office control to clone and add to the Quick Access Toolbar.
  /// </summary>
  /// <remarks>
  /// <para>
  /// Control cloning is the recommended approach for adding commands to the shared QAT because it:
  /// <list type="bullet">
  /// <item><description>Maintains consistency with Office's native UI design and behavior</description></item>
  /// <item><description>Automatically inherits the command's icon, tooltip, keyboard shortcut, and localized text</description></item>
  /// <item><description>Ensures the command works identically to its ribbon counterpart</description></item>
  /// <item><description>Adapts automatically to Office updates and different language versions</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// Common Office commands to clone to the shared QAT include:
  /// <list type="bullet">
  /// <item><description><b>FileSave, FileSaveAs:</b> Quick document saving without navigating menus</description></item>
  /// <item><description><b>Undo, Redo:</b> Essential editing commands for frequent access</description></item>
  /// <item><description><b>FilePrintQuick, FilePrint:</b> Direct printing access</description></item>
  /// <item><description><b>FormatPainter:</b> Frequently used formatting tool</description></item>
  /// <item><description><b>SpellingAndGrammar:</b> Quick proofing tools access</description></item>
  /// <item><description><b>FileSend:</b> Share or email documents quickly</description></item>
  /// <item><description><b>FileClose:</b> Close current document without closing application</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// The control identifier (idMso) must match a valid Office command ID. The available commands vary
  /// by Office application (Word, Excel, PowerPoint, etc.). Consult the Office Fluent UI Control Identifiers
  /// documentation for a complete list of valid command IDs for your target application.
  /// </para>
  /// <para>
  /// Cloned controls automatically maintain their enabled/disabled state based on context.
  /// For example, the Undo command will be disabled when there's nothing to undo, and the
  /// FileSave command may be disabled for read-only documents.
  /// </para>
  /// <para>
  /// Best practices for cloning to shared QAT:
  /// <list type="bullet">
  /// <item><description>Choose commands that are useful across all document types and workflows</description></item>
  /// <item><description>Avoid cloning commands that are highly context-specific or rarely used</description></item>
  /// <item><description>Consider user preferences - don't overload the QAT with too many items</description></item>
  /// <item><description>Test cloned commands across different document states and scenarios</description></item>
  /// </list>
  /// </para>
  /// </remarks>
  public ControlCloneQat? ControlCloneQat { get; set; }

  /// <summary>
  /// Gets or sets a custom button control to add to the Quick Access Toolbar.
  /// </summary>
  /// <remarks>
  /// <para>
  /// Custom buttons in the shared QAT execute application-level actions through add-in callbacks or macros.
  /// Unlike document-level QAT buttons, shared QAT buttons should provide functionality that makes sense
  /// across all documents. QAT buttons are optimized for immediate, single-click operations and should:
  /// <list type="bullet">
  /// <item><description>Perform well-defined, focused actions without requiring additional dialogs or steps</description></item>
  /// <item><description>Have clear, concise labels (typically 1-3 words)</description></item>
  /// <item><description>Use recognizable icons for quick visual identification</description></item>
  /// <item><description>Execute quickly without blocking the UI or requiring long operations</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// Common use cases for custom shared QAT buttons:
  /// <list type="bullet">
  /// <item><description><b>Add-in features:</b> Quick access to frequently used add-in commands (Cloud Save, CRM Lookup, Generate Report)</description></item>
  /// <item><description><b>Workflow triggers:</b> Start common processes (Submit for Review, Create from Template, Export to PDF)</description></item>
  /// <item><description><b>Application integration:</b> Launch external tools or sync with other systems</description></item>
  /// <item><description><b>Custom exports:</b> Export in specialized formats specific to your organization</description></item>
  /// <item><description><b>Utility commands:</b> Cleanup, validation, or transformation operations</description></item>
  /// <item><description><b>Quick settings:</b> Toggle application-level preferences or modes</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// Custom shared QAT buttons require callback implementations in the host add-in application.
  /// The button's <c>onAction</c> attribute specifies the callback function that will be invoked
  /// when the button is clicked. The callback receives context information about the current
  /// document and application state.
  /// </para>
  /// <para>
  /// Design considerations for shared QAT buttons:
  /// <list type="bullet">
  /// <item><description><b>Icon selection:</b> Use imageMso for Office icons when possible to maintain visual consistency</description></item>
  /// <item><description><b>Tooltips:</b> Provide clear screentips and supertips explaining the command's purpose</description></item>
  /// <item><description><b>State management:</b> Consider whether buttons should be enabled/disabled based on context</description></item>
  /// <item><description><b>Keyboard access:</b> Ensure buttons work with keyboard navigation and accelerators</description></item>
  /// <item><description><b>Error handling:</b> Gracefully handle scenarios where the action cannot be performed</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// Unlike document-level QAT buttons, shared buttons should avoid operations that only make sense
  /// for specific document types or templates. Focus on universally applicable commands that benefit
  /// users across all their documents.
  /// </para>
  /// </remarks>
  public ButtonRegular? ButtonRegular { get; set; }

  /// <summary>
  /// Gets or sets a visual separator to organize and group related commands in the Quick Access Toolbar.
  /// </summary>
  /// <remarks>
  /// <para>
  /// Separators in the shared QAT are vertical lines that visually divide commands into logical groups,
  /// improving organization and visual clarity. In the compact space of the QAT, separators help users
  /// quickly distinguish between different categories of commands.
  /// </para>
  /// <para>
  /// Best practices for using shared QAT separators:
  /// <list type="bullet">
  /// <item><description><b>Group by function:</b> Separate file operations from editing operations from custom commands</description></item>
  /// <item><description><b>Distinguish sources:</b> Use separators to show where built-in Office commands end and add-in commands begin</description></item>
  /// <item><description><b>Visual hierarchy:</b> Create clear sections for primary vs. secondary actions</description></item>
  /// <item><description><b>Use sparingly:</b> Too many separators fragment the QAT and reduce its effectiveness</description></item>
  /// <item><description><b>Logical grouping:</b> Keep related commands together before adding a separator</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// Example shared QAT organization patterns:
  /// <list type="bullet">
  /// <item><description>[Save] [Undo] [Redo] | [Add-in Command 1] [Add-in Command 2]</description></item>
  /// <item><description>[Print] [Email] | [Custom Export] | [Settings]</description></item>
  /// <item><description>[Core Office Commands...] | [Add-in Suite] | [User Customizations...]</description></item>
  /// </list>
  /// Where "|" represents a separator.
  /// </para>
  /// <para>
  /// Separators help maintain visual order in the QAT, especially important when combining:
  /// <list type="bullet">
  /// <item><description>Built-in Office commands (cloned controls)</description></item>
  /// <item><description>Custom add-in commands (custom buttons)</description></item>
  /// <item><description>User-added commands (through Office UI)</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// In shared QAT customization, separators are particularly valuable for establishing clear boundaries
  /// between different feature sets or add-ins, helping users understand which commands come from which
  /// source and making the toolbar more scannable and usable.
  /// </para>
  /// </remarks>
  public Separator? Separator { get; set; }
}