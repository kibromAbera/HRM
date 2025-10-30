import React from 'react'
import EmployeeList from './components/EmployeeList'

export default function App() {
  return (
    <div className="min-h-screen bg-gray-50 p-6">
      <div className="max-w-4xl mx-auto bg-white shadow rounded p-6">
        <h1 className="text-2xl font-bold mb-4">HRM - Employees</h1>
        <EmployeeList />
      </div>
    </div>
  )
}
