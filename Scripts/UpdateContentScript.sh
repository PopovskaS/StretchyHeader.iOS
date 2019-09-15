
plutil -convert xml1 ./StretchyHeader.iOS/Branding/AppResources.json -o ./StretchyHeader.iOS/Branding/AppResources.plist

plutil -replace headerImage -string "https://i.pinimg.com/originals/3c/8d/a4/3c8da438344c1108c20829ac430de226.jpg" ./StretchyHeader.iOS/Branding/AppResources.plist

plutil -replace title -string "Bitola" ./StretchyHeader.iOS/Branding/AppResources.plist

plutil -replace description -string "Bitola is very rich in archaeological sites from the prehistoric period. The city has many historical building dating from many historical periods. The most notable ones are from the Ottoman age, but there are some from the more recent past. Shiok Sokak is a long pedestrian street that runs from Magnolia Square to the City Park. Clock Tower is also one of the main town buildings, it is unknown when the clock tower was built. Written sources from the 16th century mention a clock tower, but it is not clear if it is the same one. Some believe it was built at the same time as St. Dimitrija Church, in 1830." ./StretchyHeader.iOS/Branding/AppResources.plist

plutil -convert json -o ./StretchyHeader.iOS/Branding/AppResources.json  ./StretchyHeader.iOS/Branding/AppResources.plist

rm ./StretchyHeader.iOS/Branding/AppResources.plist
