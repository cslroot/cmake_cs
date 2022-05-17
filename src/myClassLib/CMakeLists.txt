enable_language(CSharp)
include(CSharpUtilities)
set(PROJ_NAME_CS MyClassLib)

file(GLOB_RECURSE ${PROJ_NAME_CS}_SRC CONFIGURE_DEPENDS ${CMAKE_CURRENT_SOURCE_DIR}/*.cs)

add_library(${PROJ_NAME_CS} SHARED)
target_compile_options(${PROJ_NAME_CS} PRIVATE "/langversion:latest")
# set_property(TARGET ${PROJ_NAME_CS} PROPERTY VS_DOTNET_TARGET_FRAMEWORK_VERSION "net6.0")

target_sources(${PROJ_NAME_CS} PRIVATE ${${PROJ_NAME_CS}_SRC})

set_property(TARGET ${PROJ_NAME_CS} PROPERTY WIN32_EXECUTABLE FALSE)
set_property(TARGET ${PROJ_NAME_CS} PROPERTY VS_CONFIGURATION_TYPE ClassLibrary)
set_property(TARGET ${PROJ_NAME_CS} PROPERTY VS_DOTNET_REFERENCES
	"Microsoft.CSharp"
	"System"
	"System.Core"
	"System.Data"
	"System.Data.DatasetExtensions"
	"System.Net.Http"
	"System.Xml"
	"System.Xml.Linq"
)

target_link_libraries(${PROJ_NAME_CS} PUBLIC MyClassLibBase)
