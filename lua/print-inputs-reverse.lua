-- Author: Andrew Tompkins

backwards = function() 
t = {}
i = 1
test = true

while(test) do
t[i] = input()
if t[i] == "end" then test = false end
i=i+1
end

for count = #t,1,-1 do
print(t[count])
end
end

input = function()
  return io.read("*l")
end


