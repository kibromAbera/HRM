import React, { useEffect, useState } from 'react'
import axios from 'axios'

export default function EmployeeList() {
  const [employees, setEmployees] = useState([])

  useEffect(() => {
    axios.get('https://localhost:5173/api/employees')
      .then(res => setEmployees(res.data))
      .catch(err => console.error(err))
  }, [])

  return (
    <div>
      <table className="min-w-full text-sm">
        <thead>
          <tr>
            <th className="text-left p-2">ID</th>
            <th className="text-left p-2">Full Name (EN)</th>
            <th className="text-left p-2">Age</th>
          </tr>
        </thead>
        <tbody>
          {employees.map(e => (
            <tr key={e.id} className="border-t">
              <td className="p-2">{e.id}</td>
              <td className="p-2">{e.fullNameEnglish}</td>
              <td className="p-2">{e.age}</td>
            </tr>
          ))}
        </tbody>
      </table>
    </div>
  )
}
