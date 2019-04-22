Feature: FetureDocuments
  In order to confirm personality
  As a My Account user
  I want to upload identity documents 

Background: 
  Given User is log in and documents page is opened

Scenario: Upload pasport photo in format JPG
  When I press upload in pasport block
  And I press upload photo in pasport block
  Then The result should be name of uploaded file 'Test.jpg' in pasport block

Scenario: Upload adress document photo in format JPEG
  When I press upload in adress document block
  And I press upload photo in adress document block
  Then The result should be name of uploaded file 'Test.jpeg' in adress document block

Scenario: Upload additional document photo in format PNG
  When I press upload in additional document block
  And I press upload photo in additional document block
  Then The result should be name of uploaded file 'Test.png' in additional document block

Scenario: Upload file with invalid format in second additional document block
  When I press upload is second additional document block
  And I press upload second additional  document in second additional document block
  Then The result should be hint under button 'The file format is not supported'

Scenario: Upload file with invalid format and size in second additional document block
  When I press upload is second additional document block
  And I press upload second additional  document in second additional document block and choose file larger than allowed size
  Then The result should be hint under button 'The file format is not supported. Maximum file size is exceeded'