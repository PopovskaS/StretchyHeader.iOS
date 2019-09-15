#!/usr/bin/env bash

#Update product name by changing bundle name
 
plutil -replace CFBundleName -string "$BUNDLE_NAME" $APPCENTER_SOURCE_DIRECTORY/StretchyHeader.iOS/Info.plist

#Update product verison name by changing bundle version

plutil -replace CFBundleShortVersionString -string $BUNDLE_VERSION $APPCENTER_SOURCE_DIRECTORY/StretchyHeader.iOS/Info.plist

#Update product identifier by changing the bundle identifier

plutil -replace CFBundleIdentifier -string $BUNDLE_IDENTIFIER $APPCENTER_SOURCE_DIRECTORY/StretchyHeader.iOS/Info.plist

#Update product color palette by changing static values

find $APPCENTER_SOURCE_DIRECTORY/StretchyHeader.iOS/Branding/ColorPalette.cs -type f -exec sed -i '' "s/PrimaryColor\ =\ \(.*\)/PrimaryColor\ =\ UIColor.FromRGB($PRIMARY_COLOR_R,$PRIMARY_COLOR_G,$PRIMARY_COLOR_B);/g" {} \;

find $APPCENTER_SOURCE_DIRECTORY/StretchyHeader.iOS/Branding/ColorPalette.cs -type f -exec sed -i '' "s/AccentColor\ =\ \(.*\)/AccentColor\ =\ UIColor.FromRGB($ACCENT_COLOR_R,$ACCENT_COLOR_G,$ACCENT_COLOR_B);/g" {} \;

#Update product data by changing the json file content

plutil -convert xml1 $APPCENTER_SOURCE_DIRECTORY/StretchyHeader.iOS/Branding/AppResources.json -o $APPCENTER_SOURCE_DIRECTORY/StretchyHeader.iOS/Branding/AppResources.plist

plutil -replace headerImage -string $POSTCARD_HEADER_IMAGE $APPCENTER_SOURCE_DIRECTORY/StretchyHeader.iOS/Branding/AppResources.plist

plutil -replace title -string $POSTCARD_NAME $APPCENTER_SOURCE_DIRECTORY/StretchyHeader.iOS/Branding/AppResources.plist

plutil -replace description -string "$POSTCARD_DESCRIPTION" $APPCENTER_SOURCE_DIRECTORY/StretchyHeader.iOS/Branding/AppResources.plist

plutil -convert json -o $APPCENTER_SOURCE_DIRECTORY/StretchyHeader.iOS/Branding/AppResources.json  $APPCENTER_SOURCE_DIRECTORY/StretchyHeader.iOS/Branding/AppResources.plist

rm $APPCENTER_SOURCE_DIRECTORY/StretchyHeader.iOS/Branding/AppResources.plist 




