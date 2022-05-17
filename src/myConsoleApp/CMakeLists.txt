enable_language(CSharp)
include(CSharpUtilities)
set(PROJ_NAME_CS MyConsoleApp)

file(GLOB_RECURSE ${PROJ_NAME_CS}_SRC CONFIGURE_DEPENDS ${CMAKE_CURRENT_SOURCE_DIR}/*.cs)

add_executable(${PROJ_NAME_CS})
target_compile_options(${PROJ_NAME_CS} PRIVATE "/langversion:latest")
# set_property(TARGET ${PROJ_NAME_CS} PROPERTY VS_DOTNET_TARGET_FRAMEWORK_VERSION "net6.0")

target_sources(${PROJ_NAME_CS} PUBLIC ${${PROJ_NAME_CS}_SRC})

set_property(TARGET ${PROJ_NAME_CS} PROPERTY WIN32_EXECUTABLE FALSE)
set_property(TARGET ${PROJ_NAME_CS} PROPERTY VS_CONFIGURATION_TYPE Application)
set_target_properties(${PROJ_NAME_CS} PROPERTIES LINK_FLAGS "/SUBSYSTEM:CONSOLE")
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

target_link_libraries(${PROJ_NAME_CS} PUBLIC MyClassLib)

