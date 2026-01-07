namespace DocumentModel.Wordprocessing;

/// <summary>
/// Specifies the set of properties that define the behavior, appearance, and functionality 
/// of a structured document tag (SDT) in a WordprocessingML document.
/// </summary>
/// <remarks>
/// <para>
/// Structured document tags are objects that enable developers to attach customer-defined semantics 
/// to a region of a document via properties that are stored in separate property bags. 
/// They provide a way to create rich, structured content within Word documents that can be 
/// bound to XML data, include form controls (checkboxes, date pickers, drop-down lists), 
/// or represent specialized content types (equations, citations, bibliographies).
/// </para>
/// <para>
/// The properties defined in this interface control various aspects of SDT behavior:
/// <list type="bullet">
/// <item><description><b>Identity:</b> Unique ID, alias, and programmatic tag for referencing the SDT</description></item>
/// <item><description><b>Data Binding:</b> Mapping to Custom XML Data parts for dynamic content</description></item>
/// <item><description><b>Appearance:</b> Visual styling, color, and placeholder text</description></item>
/// <item><description><b>Content Type:</b> Specialized controls like combo boxes, date pickers, checkboxes</description></item>
/// <item><description><b>Behavior:</b> Locking, temporary status, and editing restrictions</description></item>
/// </list>
/// </para>
/// <para>
/// SDTs can be applied at different levels in the document hierarchy:
/// block-level (paragraphs), inline (runs), row-level (table rows), or cell-level (table cells).
/// The properties in this interface apply regardless of the SDT scope.
/// </para>
/// </remarks>
/// <example>
/// <code>
/// // Create a date picker SDT
/// var dateProperties = new SdtProperties
/// {
///     SdtAlias = "DocumentDate",
///     Tag = "date:created",
///     SdtContentDate = new SdtContentDate
///     {
///         DateFormat = "MM/dd/yyyy",
///         Calendar = CalendarKind.Gregorian
///     }
/// };
/// 
/// // Create a combo box SDT with data binding
/// var comboProperties = new SdtProperties
/// {
///     SdtAlias = "CustomerName",
///     Tag = "customer:name",
///     DataBinding = new DataBinding
///     {
///         XPath = "/customers/customer[@id='123']/name",
///         StoreItemId = "{guid}"
///     },
///     SdtContentComboBox = new SdtContentComboBox
///     {
///         Items = new[] { "Option 1", "Option 2", "Option 3" }
///     }
/// };
/// </code>
/// </example>
public interface SdtProperties : StoryContent
{
  /// <summary>
  /// Gets or sets the unique numerical identifier for this structured document tag.
  /// </summary>
  /// <remarks>
  /// <para>
  /// This ID uniquely identifies the SDT within the document and must be persisted across 
  /// multiple sessions (i.e., it shall not be changed once specified). The ID is used by 
  /// applications to reference and locate specific SDTs programmatically.
  /// </para>
  /// <para>
  /// The ID should be unique across all SDTs in the document. If two SDTs have the same ID,
  /// applications may exhibit undefined behavior. The value is typically a large positive integer.
  /// </para>
  /// </remarks>
  public HexInt? SdtId { get; set; }
  
  /// <summary>
  /// Gets or sets the run properties that shall be applied to text runs within the structured document tag.
  /// </summary>
  /// <remarks>
  /// These properties define the default formatting (font, size, color, etc.) for text content 
  /// within the SDT. They can be overridden by direct formatting on individual runs.
  /// This is particularly useful for applying consistent styling to all content within the SDT.
  /// </remarks>
  public RunProperties? RunProperties { get; set; }
  
  /// <summary>
  /// Gets or sets the friendly name (alias) associated with this structured document tag.
  /// </summary>
  /// <remarks>
  /// The alias provides a human-readable name for the SDT that can be displayed in user interfaces,
  /// such as the properties pane in Microsoft Word. Unlike the <see cref="Tag"/> property,
  /// which is intended for programmatic use, the alias is meant for end-users.
  /// Common examples include "Customer Name", "Order Date", or "Product Description".
  /// </remarks>
  public string? SdtAlias { get; set; }
  
  /// <summary>
  /// Gets or sets the locking behavior that controls how the content and the SDT itself can be edited.
  /// </summary>
  /// <remarks>
  /// <para>
  /// This property specifies editing restrictions for the SDT:
  /// <list type="bullet">
  /// <item><description><b>None:</b> No restrictions; both content and SDT can be edited and deleted</description></item>
  /// <item><description><b>ContentLocked:</b> Content cannot be edited, but the SDT can be deleted</description></item>
  /// <item><description><b>SdtLocked:</b> SDT cannot be deleted, but content can be edited</description></item>
  /// <item><description><b>SdtContentLocked:</b> Neither content nor SDT can be modified</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// These restrictions are enforced by the application when users interact with the document
  /// through the user interface. They do not prevent programmatic modifications.
  /// </para>
  /// </remarks>
  public LockingKind? Lock { get; set; }
  
  /// <summary>
  /// Gets or sets the placeholder configuration that defines the text displayed when the SDT is empty.
  /// </summary>
  /// <remarks>
  /// The placeholder text appears when:
  /// <list type="bullet">
  /// <item><description>The SDT's content is empty</description></item>
  /// <item><description>The associated mapped XML element is empty (when data binding is used)</description></item>
  /// <item><description>The <see cref="ShowingPlaceholder"/> property is set to <see langword="true"/></description></item>
  /// </list>
  /// The placeholder is typically styled in a light gray color and provides instructions or 
  /// context about what content should be entered (e.g., "Click here to enter text").
  /// The actual placeholder content is specified via a document part reference.
  /// </remarks>
  public SdtPlaceholder? SdtPlaceholder { get; set; }
  
  /// <summary>
  /// Gets or sets a value indicating whether the SDT is currently displaying placeholder text.
  /// </summary>
  /// <remarks>
  /// When set to <see langword="true"/>, the content of the SDT is interpreted as placeholder text
  /// rather than actual document content. This state is typically set automatically by the application
  /// but can be controlled programmatically. When a user begins editing the SDT, this property
  /// is automatically set to <see langword="false"/> and the placeholder text is replaced with user input.
  /// </remarks>
  public bool? ShowingPlaceholder { get; set; }
  
  /// <summary>
  /// Gets or sets the data binding configuration that maps this SDT to an XML element 
  /// in a Custom XML Data part.
  /// </summary>
  /// <remarks>
  /// <para>
  /// Data binding enables dynamic content in Word documents by linking SDT content to XML data.
  /// When an SDT is bound to XML data:
  /// <list type="bullet">
  /// <item><description>The SDT displays the value from the XML element specified by the XPath expression</description></item>
  /// <item><description>Changes to the SDT content are automatically written back to the XML data</description></item>
  /// <item><description>Changes to the XML data can be reflected in the SDT display</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// The <see cref="DataBinding"/> object contains:
  /// <list type="bullet">
  /// <item><description>XPath expression to locate the XML element</description></item>
  /// <item><description>Store item ID identifying the Custom XML Data part</description></item>
  /// <item><description>Optional prefix mappings for XML namespaces</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// Data binding is commonly used in document templates, mail merge scenarios, 
  /// and content management systems integration.
  /// </para>
  /// </remarks>
  public DataBinding? DataBinding { get; set; }
  
  /// <summary>
  /// Gets or sets a value indicating whether this SDT should be automatically removed 
  /// when its contents are modified.
  /// </summary>
  /// <remarks>
  /// When set to <see langword="true"/>, the SDT wrapper is removed from the document 
  /// as soon as a user edits its content, leaving only the content itself. This is useful
  /// for SDTs that serve as formatting templates or content placeholders that should 
  /// disappear once the user provides their own content. The content remains in the document;
  /// only the SDT properties and structure are removed.
  /// </remarks>
  public bool? TemporarySdt { get; set; }
  
  /// <summary>
  /// Gets or sets the programmatic tag that identifies this SDT for application code.
  /// </summary>
  /// <remarks>
  /// <para>
  /// The tag is an arbitrary string that applications can use to identify and categorize SDTs
  /// without providing a visible friendly name. Unlike <see cref="SdtAlias"/>, which is displayed
  /// to users, the tag is intended for developer use and is not typically shown in the UI.
  /// </para>
  /// <para>
  /// Common patterns for tags include:
  /// <list type="bullet">
  /// <item><description>Simple identifiers: "customerName", "orderDate"</description></item>
  /// <item><description>Namespaced identifiers: "crm:customer:name", "order:shipping:address"</description></item>
  /// <item><description>Type indicators: "required:text", "optional:date"</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// Tags enable applications to find and manipulate specific SDTs programmatically,
  /// implement business logic, or integrate with external systems.
  /// </para>
  /// </remarks>
  public string? Tag { get; set; }
  
  /// <summary>
  /// Gets or sets the color used for visual highlighting or borders of the SDT.
  /// </summary>
  /// <remarks>
  /// This color affects the visual appearance of the SDT in the document, typically
  /// as a border or background highlight when the SDT is selected or in design mode.
  /// The exact rendering depends on the <see cref="Appearance"/> setting and the application's
  /// display preferences. If not specified, the application's default SDT color is used.
  /// </remarks>
  public DM.AbstractColor? Color { get; set; }
  
  /// <summary>
  /// Gets or sets the visual appearance style for this structured document tag.
  /// </summary>
  /// <remarks>
  /// Controls how the SDT is rendered in the document:
  /// <list type="bullet">
  /// <item><description><b>BoundingBox:</b> Displays a box around the SDT content (default)</description></item>
  /// <item><description><b>Tags:</b> Displays start and end tags around the content</description></item>
  /// <item><description><b>Hidden:</b> No visual indication of the SDT (content appears normal)</description></item>
  /// </list>
  /// The appearance only affects the display; it does not change the SDT's functionality.
  /// Users may need to enable "Show content controls" in application options to see SDT markers.
  /// </remarks>
  public AppearanceKind? Appearance { get; set; }
  
  /// <summary>
  /// Gets or sets a value indicating whether this SDT is linked to a web extension (Office Add-in).
  /// </summary>
  /// <remarks>
  /// When <see langword="true"/>, the SDT is associated with a web extension that may provide
  /// custom UI, behavior, or data for the SDT. This enables integration with Office Add-ins
  /// to create rich interactive experiences. This property is typically set by the add-in
  /// when it creates or modifies the SDT.
  /// </remarks>
  public bool? WebExtensionLinked { get; set; }
  
  /// <summary>
  /// Gets or sets a value indicating whether this SDT was created by a web extension (Office Add-in).
  /// </summary>
  /// <remarks>
  /// This property tracks the origin of the SDT. When <see langword="true"/>, it indicates
  /// that a web extension created this SDT, which may affect how the SDT is handled during
  /// editing or when the add-in is not available. Applications may provide different behavior
  /// for SDTs created by add-ins versus those created through the native UI.
  /// </remarks>
  public bool? WebExtensionCreated { get; set; }
  
  /// <summary>
  /// Gets or sets a value indicating whether this SDT represents an equation content control.
  /// </summary>
  /// <remarks>
  /// When <see langword="true"/>, the SDT is designated as a container for mathematical equations.
  /// This allows the SDT to contain Office Math ML (OMML) content and enables equation editor
  /// functionality when users interact with the SDT. Only one content type property should be
  /// set to <see langword="true"/> for any given SDT.
  /// </remarks>
  public bool? SdtContentEquation { get; set; }
  
  /// <summary>
  /// Gets or sets a value indicating whether this SDT represents a picture content control.
  /// </summary>
  /// <remarks>
  /// When <see langword="true"/>, the SDT is designated as a container for image content.
  /// This enables special picture-related behaviors such as replacing the entire SDT content
  /// when a new image is inserted, and may enable picture formatting tools in the application.
  /// Only one content type property should be set to <see langword="true"/> for any given SDT.
  /// </remarks>
  public bool? SdtContentPicture { get; set; }
  
  /// <summary>
  /// Gets or sets a value indicating whether this SDT represents a rich text content control.
  /// </summary>
  /// <remarks>
  /// When <see langword="true"/>, the SDT allows full rich text formatting including multiple
  /// paragraphs, tables, images, and other complex content. This is the default behavior for
  /// most SDTs. When <see langword="false"/> or combined with <see cref="SdtContentText"/>,
  /// the SDT may be restricted to plain or limited formatting.
  /// Only one content type property should be set to <see langword="true"/> for any given SDT.
  /// </remarks>
  public bool? SdtContentRichText { get; set; }
  
  /// <summary>
  /// Gets or sets a value indicating whether this SDT represents a citation content control.
  /// </summary>
  /// <remarks>
  /// When <see langword="true"/>, the SDT is designated as a citation placeholder that integrates
  /// with the document's bibliography management features. Citation SDTs can be populated from
  /// the document's sources and formatted according to the selected citation style (APA, MLA, etc.).
  /// Only one content type property should be set to <see langword="true"/> for any given SDT.
  /// </remarks>
  public bool? SdtContentCitation { get; set; }
  
  /// <summary>
  /// Gets or sets a value indicating whether this SDT represents a group content control.
  /// </summary>
  /// <remarks>
  /// When <see langword="true"/>, the SDT acts as a grouping container for other content,
  /// potentially including nested SDTs. Group SDTs are often used to create hierarchical
  /// structures or to apply locking behavior to multiple elements as a unit. They don't
  /// typically provide their own UI but serve as logical containers.
  /// Only one content type property should be set to <see langword="true"/> for any given SDT.
  /// </remarks>
  public bool? SdtContentGroup { get; set; }
  
  /// <summary>
  /// Gets or sets a value indicating whether this SDT represents a bibliography content control.
  /// </summary>
  /// <remarks>
  /// When <see langword="true"/>, the SDT is designated as a bibliography placeholder that
  /// displays the document's bibliography (list of sources). The bibliography is automatically
  /// generated from the sources used in the document and formatted according to the selected
  /// bibliography style. This SDT updates automatically when citations are added or removed.
  /// Only one content type property should be set to <see langword="true"/> for any given SDT.
  /// </remarks>
  public bool? SdtContentBibliography { get; set; }
  
  /// <summary>
  /// Gets or sets a value indicating whether the entity picker for this SDT is in an empty state.
  /// </summary>
  /// <remarks>
  /// This property is used with entity picker content controls that allow selecting items
  /// from external data sources (such as SharePoint lists or CRM systems). When <see langword="true"/>,
  /// it indicates that no entity has been selected yet. This property is typically managed
  /// automatically by the entity picker UI component.
  /// </remarks>
  public bool? EntityPickerEmpty { get; set; }
  
  /// <summary>
  /// Gets or sets a value indicating whether this SDT is an item within a repeating section.
  /// </summary>
  /// <remarks>
  /// When <see langword="true"/>, this SDT is an individual item (row) in a repeating section
  /// structure. Repeating sections allow users to add or remove multiple instances of content
  /// with a consistent structure, similar to table rows or list items. The parent repeating
  /// section is defined by the <see cref="SdtRepeatedSection"/> property.
  /// </remarks>
  public bool? IsRepeatedSectionItem { get; set; }
  
  /// <summary>
  /// Gets or sets the plain text or formatted text content control configuration.
  /// </summary>
  /// <remarks>
  /// When set, this property defines text-specific settings for the SDT, such as whether
  /// the text should be treated as plain text (no formatting) or supports limited formatting.
  /// Plain text SDTs typically restrict content to a single run with no paragraph breaks,
  /// making them suitable for single-line input fields like names, codes, or short values.
  /// </remarks>
  public SdtContentText? SdtContentText { get; set; }
  
  /// <summary>
  /// Gets or sets the checkbox content control configuration.
  /// </summary>
  /// <remarks>
  /// When set, this property configures the SDT to display and behave as a checkbox control.
  /// The configuration includes the symbols to use for checked and unchecked states,
  /// which can be Unicode characters or symbols from specific fonts. Checkbox SDTs toggle
  /// between two states and are commonly used in forms for yes/no or true/false data entry.
  /// </remarks>
  public SdtContentCheckBox? SdtContentCheckBox { get; set; }
  
  /// <summary>
  /// Gets or sets the combo box content control configuration.
  /// </summary>
  /// <remarks>
  /// When set, this property configures the SDT as an editable combo box (drop-down list
  /// with text input). Users can either select from predefined options or type custom text.
  /// The configuration includes the list of available items, each with a display text and
  /// optional value. Combo boxes are useful when you want to provide suggestions while
  /// still allowing free-form input.
  /// </remarks>
  public SdtContentComboBox? SdtContentComboBox { get; set; }
  
  /// <summary>
  /// Gets or sets the date picker content control configuration.
  /// </summary>
  /// <remarks>
  /// When set, this property configures the SDT to display a date picker control that
  /// provides a calendar UI for date selection. The configuration includes:
  /// <list type="bullet">
  /// <item><description>Date format string for display (e.g., "MM/dd/yyyy" or "MMMM d, yyyy")</description></item>
  /// <item><description>Calendar type (Gregorian, Hijri, Hebrew, etc.)</description></item>
  /// <item><description>Locale ID for culture-specific date formatting</description></item>
  /// </list>
  /// Date picker SDTs ensure valid date entry and provide a consistent user experience
  /// for date selection across different locales.
  /// </remarks>
  public SdtContentDate? SdtContentDate { get; set; }
  
  /// <summary>
  /// Gets or sets the document part object content control configuration.
  /// </summary>
  /// <remarks>
  /// When set, this property configures the SDT to display content from a document building block
  /// (also called a document part). Document building blocks are reusable content items stored
  /// in templates or the Quick Parts gallery. The configuration specifies which building block
  /// to display. This is useful for inserting standardized content like company information,
  /// legal disclaimers, or formatted sections.
  /// </remarks>
  public SdtContentDocPartObject? SdtContentDocPartObject { get; set; }
  
  /// <summary>
  /// Gets or sets the document part list content control configuration.
  /// </summary>
  /// <remarks>
  /// When set, this property configures the SDT as a drop-down list populated with document
  /// building blocks (document parts). When a user selects an item from the list, the entire
  /// SDT is replaced with the content of the selected building block. This is useful for
  /// providing a gallery of pre-formatted content options that users can choose from,
  /// such as different clause variations or template sections.
  /// </remarks>
  public SdtContentDocPartObject? SdtContentDocPartList { get; set; }
  
  /// <summary>
  /// Gets or sets the drop-down list content control configuration.
  /// </summary>
  /// <remarks>
  /// When set, this property configures the SDT as a drop-down list with predefined options.
  /// Unlike a combo box, users can only select from the provided list items and cannot
  /// enter custom text. The configuration includes the list of items, each with display text
  /// and an optional value. Drop-down lists are ideal for enforcing selection from a fixed
  /// set of valid options, such as status values, categories, or predefined choices.
  /// </remarks>
  public SdtContentDropDownList? SdtContentDropDownList { get; set; }
  
  /// <summary>
  /// Gets or sets the repeating section content control configuration.
  /// </summary>
  /// <remarks>
  /// When set, this property configures the SDT as a repeating section that allows users
  /// to add or remove multiple instances of structured content. Each instance (row) is
  /// represented by a child SDT marked with <see cref="IsRepeatedSectionItem"/> set to
  /// <see langword="true"/>. Repeating sections are commonly used for:
  /// <list type="bullet">
  /// <item><description>Invoice line items or order details</description></item>
  /// <item><description>Multiple contact entries</description></item>
  /// <item><description>Repeating data bound to XML arrays or collections</description></item>
  /// </list>
  /// Users can add new items via UI controls, and each item maintains the same structure
  /// defined by the section's template.
  /// </remarks>
  public SdtRepeatedSection? SdtRepeatedSection { get; set; }
}