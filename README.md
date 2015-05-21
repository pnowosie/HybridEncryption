# HybridEncryption
Encryption schema inspired by Stephen Haunts [book](https://www.syncfusion.com/resources/techportal/ebooks/cryptography).

This project doesn't simple rewrite code samples from the book, but takes inspiration from it to create more complete, secure library.

# How it works?

 * Given string _m_ that have to be encrypted
 * Encrypt _m_ using symmetric algorithm with random key _ekey_
 * Compute HMAC of encrypted data with key _ekey_
 * Encrypt _ekey_ with master key (which can be a/symmetric key or DPAPI)
 * Optionaly sign HMAC value with asymmetric key


## Wanna Help?

Please do! Here's what we ask of you:

 - If you've found a bug, please log it in the Issue list. 
 - If you want to fork and fix (thanks!) - please fork then open a branch on your fork specifically for this issue. Give it a nice name.
 - Make the fix and then in your final commit message please use the Github magic syntax ("Closes #X" or Fixes etc) so we can tie your PR to you and your issue
 - Please please please verify your bug or issue with a test (we use XUnit and it's simple to get going)

Thanks so much!
