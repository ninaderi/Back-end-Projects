# Write a functin that returns a boolean if the word 'secret' is in a string
def check(mystring):
    return 'secret' in mystring.lower()
print(check('This is a Secret'))

# Create a code maker function. This function will take in a string name & replace any vowels with letter x
def code_maker(mystring):
    output = list(mystring)
    for index,letter in enumerate(mystring):
        for vowel in 'aeiou':
            if letter.lower() == vowel:
                output[index] = 'x'
    output = ''.join(output)
    return output
print(code_maker("Adam"))
