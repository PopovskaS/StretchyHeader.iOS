find ./StretchyHeader.iOS/Branding/ColorPalette.cs -type f -exec sed -i '' "s/PrimaryColor\ =\ \(.*\)/PrimaryColor\ =\ UIColor.FromRGB(128,0,0);/g" {} \;

find ./StretchyHeader.iOS/Branding/ColorPalette.cs -type f -exec sed -i '' "s/AccentColor\ =\ \(.*\)/AccentColor\ =\ UIColor.FromRGB(220,220,220);/g" {} \;

