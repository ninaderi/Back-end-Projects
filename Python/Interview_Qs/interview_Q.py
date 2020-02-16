# List comprehensions
h_letters = []
for letter in 'human':
    h_letters.append(letter)
print(h_letters)

h_letters = [ letter for letter in 'human' ]
print(h_letters)
