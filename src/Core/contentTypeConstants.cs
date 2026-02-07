using Hamfer.WebApi.Core.ContentTypes;

namespace Hamfer.WebApi.Core;

// The `type` represents the general category into which the data type falls.
// The `subtype` identifies the exact kind of data of the specified type the MIME type represents.
// An optional parameter can be added to provide additional details
// MIME type:   type/subtype;parameter=value

public static class WebApiContentType
{
  public const string MEDIA_TYPE_DELIMITER = "/";
  
// https://www.iana.org/assignments/media-types/media-types.xhtml
  public static readonly Dictionary<string, Dictionary<string,string>> CONTENT_TYPE_IANA = new() 
  {
    #region Discrete types
    { "APPLICATION", ApplicationContentType.ContentTypes },
    { "AUDIO", AudioContentType.ContentTypes },
    { "FONT", FontContentType.ContentTypes },
    { "HAPTICS", HapticsContentType.ContentTypes },
    { "IMAGE", ImageContentType.ContentTypes },
    { "MODEL", ModelContentType.ContentTypes },
    { "TEXT", TextContentType.ContentTypes },
    { "VIDEO", VideoContentTypes.ContentTypes },
    #endregion

    #region Multipart types
    { "MESSAGE", MessageContentType.ContentTypes },
    { "MULTIPART", MultipartContentType.ContentTypes },
    #endregion
  };
  
  public static readonly Dictionary<string, string> CONTENT_TYPE = new()
  {
  	//#region WEB
    {"CSS", CONTENT_TYPE_IANA["TEXT"]["css"]},   // CSS files used to style a Web page must be sent with text/css.
    {"CSV", CONTENT_TYPE_IANA["TEXT"]["csv"]},
    {"HTML", CONTENT_TYPE_IANA["TEXT"]["html"]},
    {"JS", CONTENT_TYPE_IANA["TEXT"]["javascript"]},
    {"JSON", CONTENT_TYPE_IANA["APPLICATION"]["json"]},
    {"JSONLD", CONTENT_TYPE_IANA["APPLICATION"]["ld+json"]},   // JSON-LD format
    {"MJS", CONTENT_TYPE_IANA["TEXT"]["javascript"]},   // JavaScript module
    {"PHP", "application/x-httpd-php"},   // Hypertext Preprocessor (Personal Home Page)
    {"WEB_MANIFEST", CONTENT_TYPE_IANA["APPLICATION"]["manifest+json"]},   // Web application manifest
    {"XHTML", CONTENT_TYPE_IANA["APPLICATION"]["xhtml+xml"]},

    {"ANY_APPLICATION", "application/*"},
	  //#endregion

	  //#region COMPRESSED
	  {"7Z", "application/x-7z-compressed"},
    {"ARC", "application/x-freearc"},   //Archive document (multiple files embedded)
    {"BZ", "application/x-bzip"},   // BZip archive
    {"BZ2", "application/x-bzip2"},   // BZip2 archive
    {"GZ", CONTENT_TYPE_IANA["APPLICATION"]["gzip"]},   // GZip Compressed Archive
    {"GZ_ALT", "application/x-gzip"},
    {"JAR", CONTENT_TYPE_IANA["APPLICATION"]["java-archive"]}, // Java Archive (JAR)
    {"MPKG", CONTENT_TYPE_IANA["APPLICATION"]["vnd.apple.installer+xml"]},   // Apple Installer Package
    {"RAR", CONTENT_TYPE_IANA["APPLICATION"]["vnd.rar"]},
    {"RAR_ALT", "application/x-rar-compressed"},
    {"TAR", "application/x-tar"},   // Tape Archive (TAR)
    {"ZIP", CONTENT_TYPE_IANA["APPLICATION"]["zip"]},
    {"ZIP_ALT", "application/x-zip-compressed"},
	//#endregion
  
	//#region DOCUMENTS
    {"ABW", "application/x-abiword"},   // AbiWord document
    {"AZW", "application/vnd.amazon.ebook"},    // Amazon Kindle eBook format
    {"DOC", CONTENT_TYPE_IANA["APPLICATION"]["msword"]},
    {"DOCX", CONTENT_TYPE_IANA["APPLICATION"]["vnd.openxmlformats-officedocument.wordprocessingml.document"]},
    {"EPUB", CONTENT_TYPE_IANA["APPLICATION"]["epub+zip"]},    // Electronic publication (EPUB)
    {"ICS", "text/calendar"},   // iCalendar format
    {"MD", CONTENT_TYPE_IANA["TEXT"]["markdown"]},
    {"ODP", CONTENT_TYPE_IANA["APPLICATION"]["vnd.oasis.opendocument.presentation"]},    // OpenDocument presentation document
    {"ODS", CONTENT_TYPE_IANA["APPLICATION"]["vnd.oasis.opendocument.spreadsheet"]},    // OpenDocument spreadsheet document
    {"ODT", CONTENT_TYPE_IANA["APPLICATION"]["vnd.oasis.opendocument.text"]},    // OpenDocument text document
    {"PDF", CONTENT_TYPE_IANA["APPLICATION"]["pdf"]},
    {"PPT", CONTENT_TYPE_IANA["APPLICATION"]["vnd.ms-powerpoint"]},
    {"PPTX", CONTENT_TYPE_IANA["APPLICATION"]["vnd.openxmlformats-officedocument.presentationml.presentation"]},
    {"RTF", CONTENT_TYPE_IANA["APPLICATION"]["rtf"]},
    {"VSD", CONTENT_TYPE_IANA["APPLICATION"]["vnd.visio"]},
    {"XLS", CONTENT_TYPE_IANA["APPLICATION"]["vnd.ms-excel"]},
    {"XLSX", CONTENT_TYPE_IANA["APPLICATION"]["vnd.openxmlformats-officedocument.spreadsheetml.sheet"]},
    {"XML", CONTENT_TYPE_IANA["APPLICATION"]["xml"]},
    {"XML_ALT", CONTENT_TYPE_IANA["TEXT"]["xml"]},
    {"XML_ATOM", CONTENT_TYPE_IANA["APPLICATION"]["atom+xml"]},

    {"ANY_TEXT", "text/*"},
	//#endregion
  
	//#region IMAGE
    {"APNG", CONTENT_TYPE_IANA["IMAGE"]["apng"]},   // Animated Portable Network Graphics
    {"AVIF", CONTENT_TYPE_IANA["IMAGE"]["avif"]},
    {"BMP", CONTENT_TYPE_IANA["IMAGE"]["bmp"]},
    {"GIF", CONTENT_TYPE_IANA["IMAGE"]["gif"]},   // Graphics Interchange Format (GIF)
    {"ICON", CONTENT_TYPE_IANA["IMAGE"]["vnd.microsoft.icon"]},
    {"JPEG", CONTENT_TYPE_IANA["IMAGE"]["jpeg"]},
    {"JPG", CONTENT_TYPE_IANA["IMAGE"]["jpeg"]},
    {"PNG", CONTENT_TYPE_IANA["IMAGE"]["png"]},
    {"SVG", CONTENT_TYPE_IANA["IMAGE"]["svg+xml"]},    // Scalable Vector Graphics (SVG)
    {"TIFF", CONTENT_TYPE_IANA["IMAGE"]["tiff"]},   // Tagged Image File Format (TIFF)
    {"WEBP", CONTENT_TYPE_IANA["IMAGE"]["webp"]},

    {"ANY_IMAGE", "image/*"},
	//#endregion

	//#region AUDIO
    {"3G2_AUDIO", CONTENT_TYPE_IANA["AUDIO"]["3gpp2"]},
    {"3GP_AUDIO", CONTENT_TYPE_IANA["AUDIO"]["3gpp"]},
    {"AAC", CONTENT_TYPE_IANA["AUDIO"]["aac"]},
    {"MP3", CONTENT_TYPE_IANA["AUDIO"]["mpeg"]},
    {"CDA", "application/x-cdf"},   // CD audio
    {"MIDI", "audio/x-midi"},   // Musical Instrument Digital Interface (MIDI)
    {"MIDI_ALT", "audio/midi"},
    {"OGA", CONTENT_TYPE_IANA["AUDIO"]["ogg"]},
    {"OPUS", CONTENT_TYPE_IANA["AUDIO"]["ogg"]},
    {"WAV", "audio/wav"},   // Waveform Audio Format
    {"WEBA", "audio/webm"},

    {"ANY_AUDIO", "audio/*"},
	//#endregion
  
	//#region VIDEO
    {"3G2", CONTENT_TYPE_IANA["VIDEO"]["3gpp2"]},
    {"3GP", CONTENT_TYPE_IANA["VIDEO"]["3gpp"]},
    {"AVI", "video/x-msvideo"},   //    {"AVI", Audio Video Interleave
    {"AVI_ALT", "video/avi"},
    {"MP4", CONTENT_TYPE_IANA["VIDEO"]["mp4"]},
    {"MPEG", CONTENT_TYPE_IANA["VIDEO"]["mpeg"]},
    {"OGV", CONTENT_TYPE_IANA["VIDEO"]["ogg"]},
    {"TS", CONTENT_TYPE_IANA["VIDEO"]["MP2T"]},     // MPEG transport stream
    {"WEBM", "video/webm"},
  
    {"ANY_VIDEO", "video/*"},
	//#endregion
  
	//#region FONT
    {"EOT", CONTENT_TYPE_IANA["APPLICATION"]["vnd.ms-fontobject"]},   // MS Embedded OpenType fonts
    {"OTF", CONTENT_TYPE_IANA["FONT"]["otf"]},
    {"TTF", CONTENT_TYPE_IANA["FONT"]["ttf"]},    // TrueType Font
    {"WOFF", CONTENT_TYPE_IANA["FONT"]["woff"]},   // Web Open Font Format (WOFF)
    {"WOFF2", CONTENT_TYPE_IANA["FONT"]["woff2"]},
  
    {"ANY_FONT", "font/*"},
	//#endregion
    
	//#region OTHERS
    {"CSH", "application/x-csh"},   // C-Shell script
    {"SH", "application/x-sh"},   // Bourne shell script
	//#endregion

    {"FORM_URLENCODED", CONTENT_TYPE_IANA["APPLICATION"]["x-www-form-urlencoded"]},
    {"FORM_DATA", CONTENT_TYPE_IANA["MULTIPART"]["form-data"]},
  
    {"ANY", "*/*"},
    {"TEXT", CONTENT_TYPE_IANA["TEXT"]["plain"]},    // For text documents without a specific subtype, text/plain should be used.
    {"BINARY", CONTENT_TYPE_IANA["APPLICATION"]["octet-stream"]}, // Any kind of binary data.
    {"UNRECOGNIZED", CONTENT_TYPE_IANA["APPLICATION"]["octet-stream"]}, // For binary documents without a specific or known subtype, application/octet-stream should be used.
    {"TO_DOWNLOAD", CONTENT_TYPE_IANA["APPLICATION"]["octet-stream"]}, // Browsers treat this as if the Content-Disposition header was set to attachment, and propose a "Save As" dialog.
  };
}